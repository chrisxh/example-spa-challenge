USE [Demo_SPA]
delete [dbo].[Fields]

delete [dbo].[Screens]
GO
DBCC CHECKIDENT (Screens, RESEED, 0)
GO

INSERT INTO [dbo].[Screens]([Name],[System],[Title],[LastUpdate])VALUES
           ('EPAY','PAYROLL','Employee Payment List',GETUTCDATE())
GO

INSERT INTO [dbo].[Screens]([Name],[System],[Title],[LastUpdate])VALUES
           ('LHISTORY','HR','History of Leaves',GETUTCDATE())
GO

INSERT INTO [dbo].[Screens]([Name],[System],[Title],[LastUpdate])VALUES
           ('PHISTORY','PAYROLL','History Payment List',GETUTCDATE())
GO

INSERT INTO [dbo].[Screens]([Name],[System],[Title],[LastUpdate])VALUES
           ('PARRT','PAYROLL','Payroll Report Status',GETUTCDATE())
GO

--Inserting to Fields : Screen 1
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('_TRANNO','TRANNO','Visible','TRANNO',GETUTCDATE(),1)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('_TRANNAME','TRANNAME','Visible','TRANNAME',GETUTCDATE(),1)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('_TRANSTATUS','TRANSTATUS','Visible','TRANSTATUS',GETUTCDATE(),1)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('_TRANTYPE','TRANTYPE','Visible','TRANTYPE',GETUTCDATE(),1)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S1_5','S1_5','Visible','S1_5',GETUTCDATE(),1)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S1_6','S1_6','Disabled','S1_6',GETUTCDATE(),1)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S1_7','S1_7','Disabled','S1_7',GETUTCDATE(),1)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S1_8','S1_8','Hidden','S1_8',GETUTCDATE(),1)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S1_9','S1_9','Hidden','S1_9',GETUTCDATE(),1)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S1_10','S1_10','Hidden','S1_10',GETUTCDATE(),1)
GO

--Inserting to Fields : Screen 2
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S2_1','S2_1','Visible','S2_1',GETUTCDATE(),2)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S2_2','S2_2','Disabled','S2_2',GETUTCDATE(),2)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S2_3','S2_3','Visible','S2_3',GETUTCDATE(),2)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S2_4','S2_4','Visible','S2_4',GETUTCDATE(),2)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S2_5','S2_5','Visible','S2_5',GETUTCDATE(),2)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S2_6','S2_6','Hidden','S2_6',GETUTCDATE(),2)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S2_7','S2_7','Disabled','S2_7',GETUTCDATE(),2)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S2_8','S2_8','Visible','S2_8',GETUTCDATE(),2)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S2_9','S2_9','Hidden','S2_9',GETUTCDATE(),2)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S2_10','S2_10','Hidden','S2_10',GETUTCDATE(),2)
GO

--Inserting to Fields : Screen 3
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S3_1','S3_1','Hidden','S3_1',GETUTCDATE(),3)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S3_2','S2_2','Hidden','S3_2',GETUTCDATE(),3)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S3_3','S3_3','Visible','S3_3',GETUTCDATE(),3)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S3_4','S3_4','Visible','S3_4',GETUTCDATE(),3)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S3_5','S3_5','Visible','S3_5',GETUTCDATE(),3)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S3_6','S3_6','Disabled','S3_6',GETUTCDATE(),3)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S3_7','S3_7','Disabled','S3_7',GETUTCDATE(),3)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S3_8','S3_8','Hidden','S3_8',GETUTCDATE(),3)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S3_9','S3_9','Visible','S3_9',GETUTCDATE(),3)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S3_10','S3_10','Visible','S3_10',GETUTCDATE(),3)
GO

--Inserting to Fields : Screen 4
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S4_1','S4_1','Visible','S4_1',GETUTCDATE(),4)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S4_2','S4_2','Visible','S4_2',GETUTCDATE(),4)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S4_3','S4_3','Visible','S4_3',GETUTCDATE(),4)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S4_4','S4_4','Disabled','S4_4',GETUTCDATE(),4)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S4_5','S4_5','Visible','S4_5',GETUTCDATE(),4)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S4_6','S4_6','Hidden','S4_6',GETUTCDATE(),4)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S4_7','S4_7','Disabled','S4_7',GETUTCDATE(),4)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S4_8','S4_8','Hidden','S4_8',GETUTCDATE(),4)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S4_9','S4_9','Hidden','S4_9',GETUTCDATE(),4)
GO
INSERT INTO [dbo].[Fields]([Name],[Caption],[Status],[ToolTip],[LastUpdate],[ScreenId])VALUES
           ('S4_10','S4_10','Visble','S4_10',GETUTCDATE(),4)
GO