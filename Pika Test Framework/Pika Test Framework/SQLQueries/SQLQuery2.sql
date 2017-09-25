--insert into Tests (Name, Type, FileName, Description, DateCreated, DateModified)
--values ('Lift Basic Moves', 'Kayak', 'lifttest.atr.txt',CONVERT(varbinary,'Perform basic moves and verify that there are no errors'), '2017-09-01', '2017-09-02');
insert into Labels (LabelName) values ('Lift');
insert into Labels (LabelName) values ('RPS');
insert into Labels (LabelName) values ('HFRF');
insert into Baselines (Name, FolderPath) values ('Apache', 'M:\PikaDBViews\ApacheKayak_rel\Kayak\ApacheCGAKayak');
insert into Baselines (Name, FolderPath) values ('Producer', 'M:\PikaDBViews\ProducerGKayak_rel\Kayak\GeronimoKayak\Tests');
insert into Baselines (Name, FolderPath) values ('Olympia', 'M:\PikaDBViews\OlympiaKayak_rel\Kayak\OlympiaKayak');

--select * from Labels;
select * from Baselines;