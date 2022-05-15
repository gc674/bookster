CREATE TABLE Publishers (
Id int IDENTITY(1,1) PRIMARY KEY ,
[Name] varchar(20)
);

CREATE TABLE Authors (
Id int IDENTITY(1,1) PRIMARY KEY ,
[Name] varchar(20),
Slug varchar(255) UNIQUE,
);

CREATE TABLE [Users] (
	Id int IDENTITY(1,1) PRIMARY KEY ,
	[Name] varchar(20),
	Email varchar(30),
	[Role] varchar(10)
);

CREATE TABLE Languages (
	Id int IDENTITY(1,1) PRIMARY KEY ,
	[Name] varchar(20),
	Logo varchar(100)
);

CREATE TABLE Images (
	Id int IDENTITY(1,1) PRIMARY KEY ,
	[Path] varchar(200),
	AlternativeText varchar(100)
);

CREATE TABLE Books (
    Id int IDENTITY(1,1) PRIMARY KEY ,
    Slug varchar(255) UNIQUE,
    Title varchar(100),
    [Description] varchar(500),
    PublisherId int FOREIGN KEY REFERENCES Publishers(Id),
	LanguageId int FOREIGN KEY REFERENCES Languages(Id),
	OriginalBookId int null FOREIGN KEY REFERENCES Books(Id),
	NumberOfPages int,
	ImageId int FOREIGN KEY REFERENCES Images(Id),
);

CREATE TABLE BooksAuthors (
	Id int IDENTITY(1,1) PRIMARY KEY,
	BookId int FOREIGN KEY REFERENCES Books(Id),
	AuthorId int FOREIGN KEY REFERENCES Authors(Id),
)

CREATE TABLE Awards (
	Id int IDENTITY(1,1) PRIMARY KEY,
	BookId int FOREIGN KEY REFERENCES Books(Id),
	Title varchar(100)
)

CREATE TABLE AwardsBooks (
Id int IDENTITY(1,1) PRIMARY KEY,
	BookId int FOREIGN KEY REFERENCES Books(Id),
	AwardId int FOREIGN KEY REFERENCES Awards(Id),
);

CREATE TABLE Categories (
	Id int IDENTITY(1,1) PRIMARY KEY,
	Title varchar(100),
	Slug varchar(100) Unique,
	LogoId int null FOREIGN KEY REFERENCES Images(Id),
)

CREATE TABLE CategoriesBooks (
	Id int IDENTITY(1,1) PRIMARY KEY,
	BookId int FOREIGN KEY REFERENCES Books(Id),
	CategoryId int FOREIGN KEY REFERENCES Categories(Id),
)

CREATE TABLE Articles (
	Id int IDENTITY(1,1) PRIMARY KEY,
	Title varchar(100),
	Slug varchar(100) Unique,
	ImageId int null FOREIGN KEY REFERENCES Images(Id),
	PublisherId int FOREIGN KEY REFERENCES Users(Id),
)

CREATE TABLE ArticlesBooks (
	Id int IDENTITY(1,1) PRIMARY KEY,
	BookId int FOREIGN KEY REFERENCES Books(Id),
	ArticleId int FOREIGN KEY REFERENCES Articles(Id),
)

CREATE TABLE Reviews (
	Id int IDENTITY(1,1) PRIMARY KEY,
	BookId int FOREIGN KEY REFERENCES Books(Id),
	UserId int FOREIGN KEY REFERENCES Users(Id),
	[Rank] decimal(6,4),
	Comment varchar(500),
	[Date] datetime
)

CREATE TABLE Loans (
	Id int IDENTITY(1,1) PRIMARY KEY,
	BookId int FOREIGN KEY REFERENCES Books(Id),
	UserId int FOREIGN KEY REFERENCES Users(Id),
	[Status] varchar(10)
)