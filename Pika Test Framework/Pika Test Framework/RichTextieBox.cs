using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pika_Test_Framework
{
    public partial class RichTextieBox : UserControl
    {
        private RichTextBox rtbTemp = new RichTextBox();
        public override string Text
        {
            get
            {
                return rtb1.Rtf;
            }
            set
            {
                rtb1.Rtf = value;
            }
        }

        public RichTextieBox()
        {
            InstalledFontCollection fontsCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = fontsCollection.Families;
            List<string> fonts = new List<string>();
            foreach (FontFamily font in fontFamilies)
            {
                fonts.Add(font.Name);
            }

            InitializeComponent();
            toolStripComboBox1.ComboBox.DataSource = fonts;
            /*foreach(string item in toolStripComboBox1.ComboBox.Items)
            {
                int index = toolStripComboBox1.ComboBox.Items.IndexOf(item);
                toolStripComboBox1.ComboBox.Items[index]
            }*/
            toolStripComboBox1.ComboBox.DisplayMember = "Name";
        }

        
        /// <summary>
        ///     Change the richtextbox font for the current selection
        /// </summary>
        public void ChangeFont(string fontFamily)
        {
            //This method should handle cases that occur when multiple fonts/styles are selected
            // Parameters:-
            // fontFamily - the font to be applied, eg "Courier New"

            // Reason: The reason this method and the others exist is because
            // setting these items via the selection font doen't work because
            // a null selection font is returned for a selection with more 
            // than one font!

            int rtb1start = rtb1.SelectionStart;
            int len = rtb1.SelectionLength;
            int rtbTempStart = 0;

            // If len <= 1 and there is a selection font, amend and return
            if (len <= 1 && rtb1.SelectionFont != null)
            {
                rtb1.SelectionFont =
                    new Font(fontFamily, rtb1.SelectionFont.Size, rtb1.SelectionFont.Style);
                return;
            }

            // Step through the selected text one char at a time
            rtbTemp.Rtf = rtb1.SelectedRtf;
            for (int i = 0; i < len; ++i)
            {
                rtbTemp.Select(rtbTempStart + i, 1);
                rtbTemp.SelectionFont = new Font(fontFamily, rtbTemp.SelectionFont.Size, rtbTemp.SelectionFont.Style);
            }

            // Replace & reselect
            rtbTemp.Select(rtbTempStart, len);
            rtb1.SelectedRtf = rtbTemp.SelectedRtf;
            rtb1.Select(rtb1start, len);
            return;
        }

        public void ChangeFontStyle(FontStyle style, bool add)
        {
            //This method should handle cases that occur when multiple fonts/styles are selected
            // Parameters:-
            //	style - eg FontStyle.Bold
            //	add - IF true then add else remove

            // throw error if style isn't: bold, italic, strikeout or underline
            if (style != FontStyle.Bold
                && style != FontStyle.Italic
                && style != FontStyle.Strikeout
                && style != FontStyle.Underline)
                throw new System.InvalidProgramException("Invalid style parameter to ChangeFontStyle");

            int rtb1start = rtb1.SelectionStart;
            int len = rtb1.SelectionLength;
            int rtbTempStart = 0;

            //if len <= 1 and there is a selection font then just handle and return
            if (len <= 1 && rtb1.SelectionFont != null)
            {
                //add or remove style 
                if (add)
                    rtb1.SelectionFont = new Font(rtb1.SelectionFont, rtb1.SelectionFont.Style | style);
                else
                    rtb1.SelectionFont = new Font(rtb1.SelectionFont, rtb1.SelectionFont.Style & ~style);

                return;
            }

            // Step through the selected text one char at a time	
            rtbTemp.Rtf = rtb1.SelectedRtf;
            for (int i = 0; i < len; ++i)
            {
                rtbTemp.Select(rtbTempStart + i, 1);

                //add or remove style 
                if (add)
                    rtbTemp.SelectionFont = new Font(rtbTemp.SelectionFont, rtbTemp.SelectionFont.Style | style);
                else
                    rtbTemp.SelectionFont = new Font(rtbTemp.SelectionFont, rtbTemp.SelectionFont.Style & ~style);
            }

            // Replace & reselect
            rtbTemp.Select(rtbTempStart, len);
            rtb1.SelectedRtf = rtbTemp.SelectedRtf;
            rtb1.Select(rtb1start, len);
            return;
        }

        #region Change font color
        /// <summary>
        ///     Change the richtextbox font color for the current selection
        /// </summary>
        public void ChangeFontColor(Color newColor)
        {
            //This method should handle cases that occur when multiple fonts/styles are selected
            // Parameters:-
            //	newColor - eg Color.Red

            int rtb1start = rtb1.SelectionStart;
            int len = rtb1.SelectionLength;
            int rtbTempStart = 0;

            //if len <= 1 and there is a selection font then just handle and return
            if (len <= 1 && rtb1.SelectionFont != null)
            {
                rtb1.SelectionColor = newColor;
                return;
            }

            // Step through the selected text one char at a time	
            rtbTemp.Rtf = rtb1.SelectedRtf;
            for (int i = 0; i < len; ++i)
            {
                rtbTemp.Select(rtbTempStart + i, 1);

                //change color
                rtbTemp.SelectionColor = newColor;
            }

            // Replace & reselect
            rtbTemp.Select(rtbTempStart, len);
            rtb1.SelectedRtf = rtbTemp.SelectedRtf;
            rtb1.Select(rtb1start, len);
            return;
        }
        #endregion

        private void boldButton_Click(object sender, EventArgs e)
        {
            bool add = ((ToolStripButton)sender).Checked;
            ChangeFontStyle(FontStyle.Bold, add);
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            bool add = ((ToolStripButton)sender).Checked;
            ChangeFontStyle(FontStyle.Italic, add);
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            bool add = ((ToolStripButton)sender).Checked;
            ChangeFontStyle(FontStyle.Underline, add);
        }

        private void rtb1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateToolbar();
        }

        #region Update Toolbar
        /// <summary>
        ///     Update the toolbar button statuses
        /// </summary>
        public void UpdateToolbar()
        {
            // Get the font, fontsize and style to apply to the toolbar buttons
            Font fnt = GetFontDetails();
            // Set font style buttons to the styles applying to the entire selection
            FontStyle style = fnt.Style;

            //Set all the style buttons using the gathered style
            boldButton.Checked = fnt.Bold; //bold button
            italicButton.Checked = fnt.Italic; //italic button
            underlineButton.Checked = fnt.Underline; //underline button

            //tbbStrikeout.Pushed = fnt.Strikeout; //strikeout button
            //tbbLeft.Pushed = (rtb1.SelectionAlignment == HorizontalAlignment.Left); //justify left
            //tbbCenter.Pushed = (rtb1.SelectionAlignment == HorizontalAlignment.Center); //justify center
            //tbbRight.Pushed = (rtb1.SelectionAlignment == HorizontalAlignment.Right); //justify right

            //Check the correct color
            toolStripDropDownButton2.ForeColor = rtb1.SelectionColor;
            

            toolStripComboBox1.SelectedItem = fnt.FontFamily.Name;
            /*
            //Check the correct font size
            foreach (MenuItem mi in cmFontSizes.MenuItems)
                mi.Checked = ((int)fnt.SizeInPoints == float.Parse(mi.Text));
                */
        }
        #endregion

        #region Get Font Details
        /// <summary>
        ///     Returns a Font with:
        ///     1) The font applying to the entire selection, if none is the default font. 
        ///     2) The font size applying to the entire selection, if none is the size of the default font.
        ///     3) A style containing the attributes that are common to the entire selection, default regular.
        /// </summary>		
        /// 
        public Font GetFontDetails()
        {
            //This method should handle cases that occur when multiple fonts/styles are selected

            int rtb1start = rtb1.SelectionStart;
            int len = rtb1.SelectionLength;
            int rtbTempStart = 0;

            if (len <= 1)
            {
                // Return the selection or default font
                if (rtb1.SelectionFont != null)
                    return rtb1.SelectionFont;
                else
                    return rtb1.Font;
            }

            // Step through the selected text one char at a time	
            // after setting defaults from first char
            rtbTemp.Rtf = rtb1.SelectedRtf;

            //Turn everything on so we can turn it off one by one
            FontStyle replystyle =
                FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline;

            // Set reply font, size and style to that of first char in selection.
            rtbTemp.Select(rtbTempStart, 1);
            string replyfont = rtbTemp.SelectionFont.Name;
            float replyfontsize = rtbTemp.SelectionFont.Size;
            replystyle = replystyle & rtbTemp.SelectionFont.Style;

            // Search the rest of the selection
            for (int i = 1; i < len; ++i)
            {
                rtbTemp.Select(rtbTempStart + i, 1);

                // Check reply for different style
                replystyle = replystyle & rtbTemp.SelectionFont.Style;

                // Check font
                if (replyfont != rtbTemp.SelectionFont.FontFamily.Name)
                    replyfont = "";

                // Check font size
                if (replyfontsize != rtbTemp.SelectionFont.Size)
                    replyfontsize = (float)0.0;
            }

            // Now set font and size if more than one font or font size was selected
            if (replyfont == "")
                replyfont = rtbTemp.Font.FontFamily.Name;

            if (replyfontsize == 0.0)
                replyfontsize = rtbTemp.Font.Size;

            // generate reply font
            Font reply
                = new Font(replyfont, replyfontsize, replystyle);

            return reply;
        }
        #endregion

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont(((ToolStripComboBox)sender).Text);
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ((ToolStripButton)sender).BackColor = colorDialog1.Color;
            }
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ((ToolStripDropDownButton)sender).ForeColor = colorDialog1.Color;
                ChangeFontColor(colorDialog1.Color);

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb1.SelectedRtf, TextDataFormat.Rtf);
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb1.SelectedRtf, TextDataFormat.Rtf);
            rtb1.SelectedRtf = "";
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            rtb1.SelectedRtf = Clipboard.GetText(TextDataFormat.Rtf);
        }

        public void AppendRtf(string inString)
        {
            rtb1.AppendText(inString);
        }
    }
}


