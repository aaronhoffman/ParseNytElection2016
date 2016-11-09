
CREATE TABLE [dbo].[CountyResult](
	[CountyResultId] [int] IDENTITY(1,1) NOT NULL,
	[StateCode] [varchar](10) NULL,
	[StateSlug] [varchar](100) NULL,
	[StateElectoralVotes] [int] NULL,
	[StatePrecinctsReporting] [int] NULL,
	[StatePrecinctsTotal] [int] NULL,
	[CountyFips] [varchar](100) NULL,
	[CountyName] [varchar](100) NULL,
	[CountyTotalVotes] [int] NULL,
	[CountyPrecinctsTotal] [int] NULL,
	[CountyPrecintsReporting] [int] NULL,
	[EstVotesRemaining] [int] NULL,
	[trumpd] [int] NULL,
	[clintonh] [int] NULL,
	[johnsong] [int] NULL,
	[castled] [int] NULL,
	[steinj] [int] NULL,
	[Other] [int] NULL,
 CONSTRAINT [PK_CountyResult] PRIMARY KEY CLUSTERED 
(
	[CountyResultId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
