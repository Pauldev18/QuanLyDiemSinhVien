USE [OGS]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 12/1/2023 9:03:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[fullname] [varchar](50) NOT NULL,
	[email] [varchar](70) NOT NULL,
	[phone] [varchar](20) NOT NULL,
	[gender] [tinyint] NOT NULL,
	[status] [tinyint] NOT NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 12/1/2023 9:03:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[start_date] [date] NOT NULL,
	[end_date] [date] NOT NULL,
	[open_year] [date] NOT NULL,
	[status] [int] NOT NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grading]    Script Date: 12/1/2023 9:03:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grading](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[student_id] [bigint] NOT NULL,
	[subject_id] [bigint] NOT NULL,
	[teacher_id] [bigint] NOT NULL,
	[grade] [varchar](10) NOT NULL,
	[criteria] [varchar](50) NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_Grading] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 12/1/2023 9:03:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[descriptions] [varchar](100) NOT NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 12/1/2023 9:03:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[code] [varchar](10) NOT NULL,
	[fullname] [varchar](50) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[phone] [varchar](20) NOT NULL,
	[address] [varchar](50) NOT NULL,
	[gender] [tinyint] NOT NULL,
	[birthday] [date] NOT NULL,
	[status] [tinyint] NOT NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 12/1/2023 9:03:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[course_id] [bigint] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 12/1/2023 9:03:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[subject_id] [bigint] NOT NULL,
	[code] [varchar](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[phone] [varchar](20) NOT NULL,
	[fullname] [varchar](50) NOT NULL,
	[address] [varchar](100) NOT NULL,
	[gender] [tinyint] NOT NULL,
	[status] [tinyint] NOT NULL,
	[birthday] [date] NOT NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/1/2023 9:03:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[role_id] [bigint] NOT NULL,
	[teacher_id] [bigint] NULL,
	[student_id] [bigint] NULL,
	[admin_id] [bigint] NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admins] ON 

INSERT [dbo].[Admins] ([id], [fullname], [email], [phone], [gender], [status], [created_at], [updated_at]) VALUES (2, N'Le Thanh Dat', N'datle@gmail.com', N'0987666844', 0, 1, CAST(N'2023-12-01T20:00:03.897' AS DateTime), CAST(N'2023-12-01T20:00:03.897' AS DateTime))
INSERT [dbo].[Admins] ([id], [fullname], [email], [phone], [gender], [status], [created_at], [updated_at]) VALUES (3, N'Hoang Hai Phong', N'phong@gmail.com', N'0988777656', 0, 1, CAST(N'2023-12-01T20:00:03.897' AS DateTime), CAST(N'2023-12-01T20:00:03.897' AS DateTime))
SET IDENTITY_INSERT [dbo].[Admins] OFF
GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([id], [name], [start_date], [end_date], [open_year], [status], [created_at], [updated_at]) VALUES (1, N'Database Design', CAST(N'2023-08-08' AS Date), CAST(N'2023-08-12' AS Date), CAST(N'2023-08-08' AS Date), 1, CAST(N'2023-12-01T20:10:16.293' AS DateTime), CAST(N'2023-12-01T20:10:16.293' AS DateTime))
INSERT [dbo].[Courses] ([id], [name], [start_date], [end_date], [open_year], [status], [created_at], [updated_at]) VALUES (3, N'Graphic Design', CAST(N'2024-04-13' AS Date), CAST(N'2024-08-13' AS Date), CAST(N'2024-04-13' AS Date), 0, CAST(N'2023-12-01T20:11:42.783' AS DateTime), CAST(N'2023-12-01T20:11:42.783' AS DateTime))
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO
SET IDENTITY_INSERT [dbo].[Grading] ON 

INSERT [dbo].[Grading] ([id], [student_id], [subject_id], [teacher_id], [grade], [criteria], [created_at], [updated_at]) VALUES (1, 2, 2, 2, N'90', N'Distinction', NULL, NULL)
INSERT [dbo].[Grading] ([id], [student_id], [subject_id], [teacher_id], [grade], [criteria], [created_at], [updated_at]) VALUES (2, 1, 1, 1, N'50', N'Fail', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Grading] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([id], [name], [descriptions], [created_at], [updated_at]) VALUES (1, N'Student', N'Rights for students', CAST(N'2023-12-01T19:56:29.033' AS DateTime), CAST(N'2023-12-01T19:56:29.033' AS DateTime))
INSERT [dbo].[Roles] ([id], [name], [descriptions], [created_at], [updated_at]) VALUES (2, N'Admin', N'Rights for admins', CAST(N'2023-12-01T19:56:29.037' AS DateTime), CAST(N'2023-12-01T19:56:29.037' AS DateTime))
INSERT [dbo].[Roles] ([id], [name], [descriptions], [created_at], [updated_at]) VALUES (3, N'Teacher', N'Righhts for teacher', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([id], [code], [fullname], [email], [phone], [address], [gender], [birthday], [status], [created_at], [updated_at]) VALUES (1, N'BH00986', N'Dinh Manh Hai', N'manhhai@gmail,com', N'0988419004', N'Nam Dinh', 0, CAST(N'2004-09-15' AS Date), 1, NULL, NULL)
INSERT [dbo].[Students] ([id], [code], [fullname], [email], [phone], [address], [gender], [birthday], [status], [created_at], [updated_at]) VALUES (2, N'BH00987', N'Nguyen Thi Kieu Anh', N'kieuanh@gmail,com', N'04378257873', N'Ha Noi', 1, CAST(N'2004-07-10' AS Date), 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([id], [course_id], [name], [created_at], [updated_at]) VALUES (1, 1, N'Database Design Development', CAST(N'2023-12-01T20:17:38.513' AS DateTime), CAST(N'2023-12-01T20:17:38.513' AS DateTime))
INSERT [dbo].[Subjects] ([id], [course_id], [name], [created_at], [updated_at]) VALUES (2, 3, N'Graphic', CAST(N'2023-12-01T20:17:38.513' AS DateTime), CAST(N'2023-12-01T20:17:38.513' AS DateTime))
SET IDENTITY_INSERT [dbo].[Subjects] OFF
GO
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([id], [subject_id], [code], [email], [phone], [fullname], [address], [gender], [status], [birthday], [created_at], [updated_at]) VALUES (1, 1, N'AH113', N'thodinh@gmail.com', N'0988767778', N'Dinh Van Tho', N'Quang Ninh', 0, 1, CAST(N'1989-12-12' AS Date), NULL, NULL)
INSERT [dbo].[Teachers] ([id], [subject_id], [code], [email], [phone], [fullname], [address], [gender], [status], [birthday], [created_at], [updated_at]) VALUES (2, 2, N'AH114', N'trucmay@gmail.com', N'0988417762', N'Hoang Truc Anh', N'Bac Ninh', 1, 1, CAST(N'1997-10-22' AS Date), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Teachers] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [role_id], [teacher_id], [student_id], [admin_id], [email], [password], [created_at], [updated_at]) VALUES (2, 1, NULL, 2, NULL, N'kieuanh@gmail.com', N'321', NULL, NULL)
INSERT [dbo].[Users] ([id], [role_id], [teacher_id], [student_id], [admin_id], [email], [password], [created_at], [updated_at]) VALUES (3, 3, 1, NULL, NULL, N'thodinh@gmail.com', N'1234', NULL, NULL)
INSERT [dbo].[Users] ([id], [role_id], [teacher_id], [student_id], [admin_id], [email], [password], [created_at], [updated_at]) VALUES (4, 2, NULL, NULL, 2, N'datle@gmail.com', N'123', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Grading]  WITH CHECK ADD  CONSTRAINT [FK_Grading_Students] FOREIGN KEY([student_id])
REFERENCES [dbo].[Students] ([id])
GO
ALTER TABLE [dbo].[Grading] CHECK CONSTRAINT [FK_Grading_Students]
GO
ALTER TABLE [dbo].[Grading]  WITH CHECK ADD  CONSTRAINT [FK_Grading_Subjects] FOREIGN KEY([subject_id])
REFERENCES [dbo].[Subjects] ([id])
GO
ALTER TABLE [dbo].[Grading] CHECK CONSTRAINT [FK_Grading_Subjects]
GO
ALTER TABLE [dbo].[Grading]  WITH CHECK ADD  CONSTRAINT [FK_Grading_Teachers] FOREIGN KEY([teacher_id])
REFERENCES [dbo].[Teachers] ([id])
GO
ALTER TABLE [dbo].[Grading] CHECK CONSTRAINT [FK_Grading_Teachers]
GO
ALTER TABLE [dbo].[Subjects]  WITH CHECK ADD  CONSTRAINT [FK_Subjects_Courses] FOREIGN KEY([course_id])
REFERENCES [dbo].[Courses] ([id])
GO
ALTER TABLE [dbo].[Subjects] CHECK CONSTRAINT [FK_Subjects_Courses]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [FK_Teachers_Subjects] FOREIGN KEY([subject_id])
REFERENCES [dbo].[Subjects] ([id])
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [FK_Teachers_Subjects]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Admins] FOREIGN KEY([admin_id])
REFERENCES [dbo].[Admins] ([id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Admins]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Students] FOREIGN KEY([student_id])
REFERENCES [dbo].[Students] ([id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Students]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Teachers] FOREIGN KEY([teacher_id])
REFERENCES [dbo].[Teachers] ([id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Teachers]
GO
