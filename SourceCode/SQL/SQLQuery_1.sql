SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[AppointmentID] [int] IDENTITY(1,1) NOT NULL,
	[AppointmentName] [varchar](255) NOT NULL,
	[AppointmentDescription] [varchar](255) NULL,
	[AppointmentTarget] [varchar](255) NOT NULL,
	[AppointmentTime] [datetime2](7) NOT NULL,
	[AppointmentNote] [varchar](400) NULL,
	[AppointmentIsComplete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
