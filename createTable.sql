CREATE TABLE Patient(

	ID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	Fullname varchar(256) NOT NULL,
	IdentifyNumber varchar(11),
	Birthdate DateTime NOT NULL,
	Sex varchar(16) NOT NULL,
	Email varchar(256) NOT NULL,
	Nationality int NOT NULL,
	GDPRAgree bit NOT NULL

);