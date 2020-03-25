

CREATE TABLE Venues (
  VenueID numeric(4) NOT NULL ,
  VenueName varchar2(80) NOT NULL,
  Street varchar2(30) NOT NULL,
  Town varchar2(30) NOT NULL,
  County varchar2(30) NOT NULL,
  ManagerName varchar2(50) NOT NULL,
  ManagerEmail varchar2(60) NOT NULL,
  ManagerMobile varchar2(20) NOT NULL,
  Status char(1) DEFAULT 'Y',
  MaxCapacity numeric(5) NOT NULL,
  CONSTRAINT pk_VenueID PRIMARY KEY (VenueID));


INSERT INTO Venues (VenueID, VenueName, Street, Town, County, ManagerName, ManagerEmail, ManagerMobile, MaxCapacity)  
VALUES(1,'Blasket Bar', 'Lower Castle St.', 'Tralee ','Kerry', 'Micheal Donovan',  'stbridgey@hotmail.co.uk','087 123 5698', 2000);


CREATE TABLE Events (
  EventID numeric(2) NOT NULL,
  VenueID numeric(2) NOT NULL,
  VenueName varchar2(80) NOT NULL,
  Title varchar2(50) NOT NULL,
  Description varchar2(140),
  EventDate varchar2(30) NOT NULL,
  EventTime varchar2(20) NOT NULL,
  TicketsAvailable numeric (3),
  Price numeric(5,2),
  Status char(1) DEFAULT 'S',
  CONSTRAINT pk_EventID PRIMARY KEY (EventID),
  CONSTRAINT fk_Venue_VenID FOREIGN KEY (VenueID) REFERENCES Venues);
  
  
INSERT INTO Events (EventID, VenueID, VenueName, Title, Description,  EventDate, EventTime, TicketsAvailable, Price)  
VALUES(1, 1, 'Blasket Bar', 'Grand Dance', 'Night of Dancing and More', '10-Jan-20', '20:00', 100, 15.00);




--CUSTOMERS TABLE

CREATE TABLE Customers (
  CustID varchar2(6) NOT NULL,
  FNAme varchar2(20) NOT NULL,
  SName varchar2(20) NOT NULL,
  Email varchar2(30) NOT NULL UNIQUE,
  Password varchar2(8)NOT NULL,
  ContactNo varchar2(14) NOT NULL,
  Balance numeric(6,2) DEFAULT 0,
  CONSTRAINT pk_CustID PRIMARY KEY (CustID)
  );
  
  
INSERT INTO Customers (CustID, FNAme, SName, Email, Password, ContactNo, Balance)  
VALUES(1, 'Mary', 'Murphy', 'mmurphy@gmail.com', 'murphy13', '0831254569', 45.00);


--BOOKINGS TABLE


CREATE TABLE Bookings (
  BookingID numeric(8) NOT NULL,
  CustID varchar2(6) NOT NULL,
  EventID numeric(4) NOT NULL,
  BookingDate date DEFAULT sysdate,
  NoTickets numeric (1) NOT NULL,
  BookingTotal numeric(6,2),
  CONSTRAINT pk_BookingID PRIMARY KEY (BookingID),
  CONSTRAINT fk_Customers_CustID FOREIGN KEY (CustID) REFERENCES Customers,
  CONSTRAINT fk_Event_EventID FOREIGN KEY (EventID) REFERENCES Events
  );
  
  
INSERT INTO Bookings (BookingID, CustID, EventID, NoTickets, BookingTotal)  
VALUES(1, 1, 1, 3, 45.00);

COMMIT;








