USE [master]
GO
/****** Object:  Database [DigitalSkills 2021]    Script Date: 12.08.2021 16:00:48 ******/
CREATE DATABASE [DigitalSkills]
GO
USE [DigitalSkills]
GO
CREATE TABLE [dbo].[author](
	[id] [varchar](128) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[bio] [nvarchar](1000) NULL,
	[birth_date] [date] NULL,
	[deat_hdate] [date] NULL,
	[wikipedia] [nvarchar](225) NULL,
 CONSTRAINT [PK_author] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[book]    Script Date: 12.08.2021 16:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[book](
	[id] [varchar](128) NOT NULL,
	[title] [nvarchar](500) NOT NULL,
	[subtitle] [nvarchar](500) NULL,
	[first_publish_date] [nvarchar](20) NULL,
	[descriprion] [nvarchar](max) NULL,
 CONSTRAINT [PK_book] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[book_author]    Script Date: 12.08.2021 16:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[book_author](
	[id_book] [varchar](128) NOT NULL,
	[id_author] [varchar](128) NOT NULL,
 CONSTRAINT [PK_book_author] PRIMARY KEY CLUSTERED 
(
	[id_book] ASC,
	[id_author] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[book_customer]    Script Date: 12.08.2021 16:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[book_customer](
	[id_book] [varchar](128) NOT NULL,
	[id_customer] [nchar](5) NOT NULL,
	[date_of_issue] [date] NOT NULL,
	[return_date] [date] NULL,
 CONSTRAINT [PK_book_customer] PRIMARY KEY CLUSTERED 
(
	[id_book] ASC,
	[id_customer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 12.08.2021 16:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[id] [nchar](5) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[address] [nvarchar](200) NOT NULL,
	[zip] [int] NOT NULL,
	[city] [nvarchar](100) NOT NULL,
	[phone] [varchar](13) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 12.08.2021 16:00:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[login] [nchar](10) NOT NULL,
	[password] [nchar](10) NOT NULL,
	[id_customer] [nchar](5) NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[author] ([id], [name], [bio], [birth_date], [deat_hdate], [wikipedia]) VALUES (N'ASD2313', N'Панфилов Павел Алексеевич', N'sddssdfdsf', CAST(N'2002-08-14' AS Date), NULL, N'assfsdfdsdsfsdfdsfdsf')
INSERT [dbo].[author] ([id], [name], [bio], [birth_date], [deat_hdate], [wikipedia]) VALUES (N'DFD324F', N'Автор Номер 2', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[book] ([id], [title], [subtitle], [first_publish_date], [descriprion]) VALUES (N'OL13716955W', N'Harry Potter and the Order of the Phoenix', NULL, NULL, NULL)
INSERT [dbo].[book] ([id], [title], [subtitle], [first_publish_date], [descriprion]) VALUES (N'OL14862437W', N'The homeplace', NULL, NULL, NULL)
INSERT [dbo].[book] ([id], [title], [subtitle], [first_publish_date], [descriprion]) VALUES (N'OL15175878W', N'Moby Dick, or The White Whale', NULL, NULL, NULL)
INSERT [dbo].[book] ([id], [title], [subtitle], [first_publish_date], [descriprion]) VALUES (N'OL15202028W', N'Les Misйrables', NULL, NULL, NULL)
INSERT [dbo].[book] ([id], [title], [subtitle], [first_publish_date], [descriprion]) VALUES (N'OL1793183W', N'Three Men in a Boat (to say nothing of the dog)', NULL, NULL, NULL)
INSERT [dbo].[book] ([id], [title], [subtitle], [first_publish_date], [descriprion]) VALUES (N'OL262758W', N'The Hobbit', N'dsdasassdfdsfsdfsd', N'2020-02-02', N'fsdfsdfsdfsdfsdfsdfdsfdsf')
INSERT [dbo].[book] ([id], [title], [subtitle], [first_publish_date], [descriprion]) VALUES (N'OL5735363W', N'The Hunger Games', NULL, NULL, NULL)
INSERT [dbo].[book] ([id], [title], [subtitle], [first_publish_date], [descriprion]) VALUES (N'OL76837W', N'The Da Vinci Code', NULL, NULL, NULL)
GO
INSERT [dbo].[book_author] ([id_book], [id_author]) VALUES (N'OL262758W', N'ASD2313')
INSERT [dbo].[book_author] ([id_book], [id_author]) VALUES (N'OL262758W', N'DFD324F')
GO
INSERT [dbo].[book_customer] ([id_book], [id_customer], [date_of_issue], [return_date]) VALUES (N'OL13716955W', N'C1028', CAST(N'2017-02-03' AS Date), CAST(N'2017-02-21' AS Date))
INSERT [dbo].[book_customer] ([id_book], [id_customer], [date_of_issue], [return_date]) VALUES (N'OL14862437W', N'C1017', CAST(N'2017-03-01' AS Date), CAST(N'2017-03-12' AS Date))
INSERT [dbo].[book_customer] ([id_book], [id_customer], [date_of_issue], [return_date]) VALUES (N'OL14862437W', N'C1028', CAST(N'2017-05-26' AS Date), CAST(N'2017-06-16' AS Date))
INSERT [dbo].[book_customer] ([id_book], [id_customer], [date_of_issue], [return_date]) VALUES (N'OL14862437W', N'C1029', CAST(N'2017-02-06' AS Date), CAST(N'2017-02-20' AS Date))
INSERT [dbo].[book_customer] ([id_book], [id_customer], [date_of_issue], [return_date]) VALUES (N'OL14862437W', N'C1031', CAST(N'2017-03-25' AS Date), CAST(N'2017-04-09' AS Date))
INSERT [dbo].[book_customer] ([id_book], [id_customer], [date_of_issue], [return_date]) VALUES (N'OL15175878W', N'C1028', CAST(N'2017-06-03' AS Date), CAST(N'2017-06-11' AS Date))
INSERT [dbo].[book_customer] ([id_book], [id_customer], [date_of_issue], [return_date]) VALUES (N'OL15175878W', N'C1029', CAST(N'2017-05-24' AS Date), NULL)
INSERT [dbo].[book_customer] ([id_book], [id_customer], [date_of_issue], [return_date]) VALUES (N'OL15202028W', N'C1028', CAST(N'2017-04-03' AS Date), CAST(N'2017-05-05' AS Date))
INSERT [dbo].[book_customer] ([id_book], [id_customer], [date_of_issue], [return_date]) VALUES (N'OL1793183W', N'C1028', CAST(N'2017-05-26' AS Date), NULL)
INSERT [dbo].[book_customer] ([id_book], [id_customer], [date_of_issue], [return_date]) VALUES (N'OL262758W', N'C1028', CAST(N'2017-01-13' AS Date), CAST(N'2017-01-23' AS Date))
INSERT [dbo].[book_customer] ([id_book], [id_customer], [date_of_issue], [return_date]) VALUES (N'OL5735363W', N'C1028', CAST(N'2017-06-03' AS Date), NULL)
INSERT [dbo].[book_customer] ([id_book], [id_customer], [date_of_issue], [return_date]) VALUES (N'OL76837W', N'C1028', CAST(N'2017-06-03' AS Date), NULL)
INSERT [dbo].[book_customer] ([id_book], [id_customer], [date_of_issue], [return_date]) VALUES (N'OL76837W', N'C1031', CAST(N'2017-05-25' AS Date), NULL)
GO
INSERT [dbo].[customer] ([id], [name], [address], [zip], [city], [phone], [email]) VALUES (N'C1005', N'Kenneth Wright', N'4070 Viverra.  Avenue', 72604, N'Lac-Serent', N'202-555-0147', N'kwright@gmail.com')
INSERT [dbo].[customer] ([id], [name], [address], [zip], [city], [phone], [email]) VALUES (N'C1006', N'Kylie Green', N'4196 Pharetra  Straße', 8071, N'Northumberland', N'307-555-0125', N'kylie1990@msn.com')
INSERT [dbo].[customer] ([id], [name], [address], [zip], [city], [phone], [email]) VALUES (N'C1013', N'Shelley Howard', N'5193 Aliquet Rd.', 5404, N'Broxburn', N'410-555-0161', N'howardshelley@outlook.com')
INSERT [dbo].[customer] ([id], [name], [address], [zip], [city], [phone], [email]) VALUES (N'C1017', N'Nash Charles', N'3549 Nullam  Rd.', 487505, N'Turrialba', N'208-555-0115', N'nash_charles@yahoo.com')
INSERT [dbo].[customer] ([id], [name], [address], [zip], [city], [phone], [email]) VALUES (N'C1021', N'Tad Curry', N'8702 Dolor.  Straße', 52201, N'Carbonear', N'617-555-0184', N'tad80curry@gmail.com')
INSERT [dbo].[customer] ([id], [name], [address], [zip], [city], [phone], [email]) VALUES (N'C1025', N'Quon Palmer', N'7125 Aliquam  Straße', 20248, N'Quimper', N'803-555-0173', N'palmer_quimper@msn.com')
INSERT [dbo].[customer] ([id], [name], [address], [zip], [city], [phone], [email]) VALUES (N'C1027', N'Ulric Stein', N'2438 Ornare  Straße', 9663, N'Río Hurtado', N'860-555-0157', N'stein7125@outlook.com')
INSERT [dbo].[customer] ([id], [name], [address], [zip], [city], [phone], [email]) VALUES (N'C1028', N'Grace Bridges', N'243-9174 Semper St.', 717993, N'Chaudfontaine', N'808-555-0116', N'grace.bridges@yahoo.com')
INSERT [dbo].[customer] ([id], [name], [address], [zip], [city], [phone], [email]) VALUES (N'C1029', N'Jasper Sweet', N'564-8483 Cursus  Avenue', 21300, N'York', N'601-555-0103', N'sweety_jasper@gmail.com')
INSERT [dbo].[customer] ([id], [name], [address], [zip], [city], [phone], [email]) VALUES (N'C1030', N'Blair Glenn', N'457-157 Luctus  Rd.', 644373, N'Vilna', N'405-555-0163', N'blair_glenn@msn.com')
INSERT [dbo].[customer] ([id], [name], [address], [zip], [city], [phone], [email]) VALUES (N'C1031', N'Bianca Mendoza', N'2001 Sem St.', 151099, N'Constitución', N'919-555-0122', N'bmendoza@outlook.com')
INSERT [dbo].[customer] ([id], [name], [address], [zip], [city], [phone], [email]) VALUES (N'C1032', N'dsfdf', N'fdsfdsfsdf', 2133, N'sdfdsf', N'dsfsdf', N'sdfsdf')
INSERT [dbo].[customer] ([id], [name], [address], [zip], [city], [phone], [email]) VALUES (N'C1033', N'ewrewdf', N'dsfsdf', 444, N'dfdsf', N'fsdf', N'sdfdsf')
GO
INSERT [dbo].[user] ([login], [password], [id_customer]) VALUES (N'admin     ', N'123       ', N'C1005')
GO
ALTER TABLE [dbo].[book_author]  WITH CHECK ADD  CONSTRAINT [FK_book_author_author] FOREIGN KEY([id_author])
REFERENCES [dbo].[author] ([id])
GO
ALTER TABLE [dbo].[book_author] CHECK CONSTRAINT [FK_book_author_author]
GO
ALTER TABLE [dbo].[book_author]  WITH CHECK ADD  CONSTRAINT [FK_book_author_book] FOREIGN KEY([id_book])
REFERENCES [dbo].[book] ([id])
GO
ALTER TABLE [dbo].[book_author] CHECK CONSTRAINT [FK_book_author_book]
GO
ALTER TABLE [dbo].[book_customer]  WITH CHECK ADD  CONSTRAINT [FK_book_customer_book] FOREIGN KEY([id_book])
REFERENCES [dbo].[book] ([id])
GO
ALTER TABLE [dbo].[book_customer] CHECK CONSTRAINT [FK_book_customer_book]
GO
ALTER TABLE [dbo].[book_customer]  WITH CHECK ADD  CONSTRAINT [FK_book_customer_customer] FOREIGN KEY([id_customer])
REFERENCES [dbo].[customer] ([id])
GO
ALTER TABLE [dbo].[book_customer] CHECK CONSTRAINT [FK_book_customer_customer]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [FK_user_customer] FOREIGN KEY([id_customer])
REFERENCES [dbo].[customer] ([id])
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [FK_user_customer]
GO
USE [master]
GO
ALTER DATABASE [DigitalSkills 2021] SET  READ_WRITE 
GO
