
drop table VENUES cascade constraints;
drop table EVENTS cascade constraints;
drop table CUSTOMERS cascade constraints;
drop table BOOKINGS cascade constraints;



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
VALUES(1,'Club', 'Some Street', 'Cork','Cork', 'John Sullivan',  'Club@gmail.com','0834279944', 2000);
                                     
INSERT INTO Venues (VenueID, VenueName, Street, Town, County, ManagerName, ManagerEmail, ManagerMobile, MaxCapacity)  
VALUES(2,'Bar', 'Bar Street', 'Killarney ','Kerry', 'Joe Sullivan',  'Bar@gmail.com','0834822949', 150);
                                     
INSERT INTO Venues (VenueID, VenueName, Street, Town, County, ManagerName, ManagerEmail, ManagerMobile, MaxCapacity)  
VALUES(3,'Balsket', 'Main Road', 'Tralee ','Kerry', 'Mary Delaney',  'Blasket@gmail.com','0834822219', 500);
                                     
INSERT INTO Venues (VenueID, VenueName, Street, Town, County, ManagerName, ManagerEmail, ManagerMobile, MaxCapacity)  
VALUES(4,'Hennesys', '3rd Street', 'Tralee ','Kerry', 'Mary Sullivan',  'Club@gmail.com','0834879949', 800);
                                     
                                     
                                     
                                     
                                     
CREATE TABLE Events (
  EventID numeric(4) NOT NULL,
  VenueID numeric(4) NOT NULL,
  VenueName varchar2(80) NOT NULL,
  Title varchar2(50) NOT NULL,
  Description varchar2(140),
  EventDate varchar2(30) NOT NULL,
  EventTime varchar2(20) NOT NULL,
  TicketsAvailable numeric (5) NOT NULL,
  Price numeric(5,2) NOT NULL,
  Status char(1) DEFAULT 'Y' NOT NULL,
  CONSTRAINT pk_EventID PRIMARY KEY (EventID),
  CONSTRAINT fk_Venue_VenID FOREIGN KEY (VenueID) REFERENCES Venues);
  
--Tickets in pre made bookings taken away fromt hese tickets available
                                     
INSERT INTO Events (EventID, VenueID, VenueName, Title, Description,  EventDate, EventTime, TicketsAvailable, Price)  
VALUES(1, 1, 'Club', 'Party', 'Drinks and Dancing', '2020-10-20', '20:00', 1485, 25.00);

INSERT INTO Events (EventID, VenueID, VenueName, Title, Description,  EventDate, EventTime, TicketsAvailable, Price)  
VALUES(2, 2, 'Bar', 'Party', 'Darts', '2020-06-20', '18:00', 88, 35.00);
                                     
INSERT INTO Events (EventID, VenueID, VenueName, Title, Description,  EventDate, EventTime, TicketsAvailable, Price)  
VALUES(3, 3, 'Blasket Bar', 'Party', 'Bingo', '2020-08-20', '21:00', 396, 15.00);
                                     
INSERT INTO Events (EventID, VenueID, VenueName, Title, Description,  EventDate, EventTime, TicketsAvailable, Price)  
VALUES(4, 4, 'Hennesys', 'Party', 'Singing', '2020-10-10', '21:00', 232, 20.00);



--CUSTOMERS TABLE

CREATE TABLE Customers (
  CustID numeric(5) NOT NULL,
  forename varchar2(20) NOT NULL,
  surname varchar2(20) NOT NULL,
  Email varchar2(40) NOT NULL UNIQUE,
  Password varchar2(8)NOT NULL,
  ContactNo varchar2(14) NOT NULL,
  CONSTRAINT pk_CustID PRIMARY KEY (CustID)
  );
  
  
INSERT INTO Customers (CustID, forename, surname, Email, Password, ContactNo)  
VALUES(1, 'Michal', 'Kubiak', 'michal@gmail.com', 'michal', '0831654666');
                                     
INSERT INTO Customers (CustID, forename, surname, Email, Password, ContactNo)  
VALUES(2, 'Steph', 'Collins', 'steph@gmail.com', 'steph', '0831654222');
                                     
INSERT INTO Customers (CustID, forename, surname, Email, Password, ContactNo)  
VALUES(3, 'Travis', 'Slattery', 'travis@gmail.com', 'travis', '0831212311');


--BOOKINGS TABLE


CREATE TABLE Bookings (
  BookingID numeric(8) NOT NULL,
  CustID numeric(5) NOT NULL,
  EventID numeric(4) NOT NULL,
  BookingDate varchar(10) NOT NULL,
  NoTickets numeric(2) NOT NULL,
  BookingTotal numeric(6,2) NOT NULL,
  Status char(1) Default 'Y' NOT NULL,
  CONSTRAINT pk_BookingID PRIMARY KEY (BookingID),
  CONSTRAINT fk_Customers_CustID FOREIGN KEY (CustID) REFERENCES Customers,
  CONSTRAINT fk_Event_EventID FOREIGN KEY (EventID) REFERENCES Events
  );
                                     
                                     
INSERT INTO Events (EventID, VenueID, VenueName, Title, Description,  EventDate, EventTime, TicketsAvailable, Price)  
VALUES(1, 1, 'Club', 'Party', 'Drinks and Dancing', '2020-10-20', '20:00', 1400, 25.00);
INSERT INTO Events (EventID, VenueID, VenueName, Title, Description,  EventDate, EventTime, TicketsAvailable, Price)  
VALUES(2, 2, 'Bar', 'Party', 'Darts', '2020-06-20', '18:00', 90, 35.00);
INSERT INTO Events (EventID, VenueID, VenueName, Title, Description,  EventDate, EventTime, TicketsAvailable, Price)  
VALUES(3, 3, 'Blasket Bar', 'Party', 'Bingo', '2020-08-20', '21:00', 400, 15.00);
INSERT INTO Events (EventID, VenueID, VenueName, Title, Description,  EventDate, EventTime, TicketsAvailable, Price)  
VALUES(4, 4, 'Hennesys', 'Party', 'Singing', '2020-10-10', '21:00', 240, 20.00);

  

INSERT INTO Bookings (BookingID, CustID, EventID, BookingDate, NoTickets, BookingTotal)  
VALUES(1, 1, 1, '2020-04-08' , 3, 75.00);
                                     
INSERT INTO Bookings (BookingID, CustID, EventID, BookingDate, NoTickets, BookingTotal)  
VALUES(2, 1, 2, '2020-04-08' , 1, 35.00);
                                     
INSERT INTO Bookings (BookingID, CustID, EventID, BookingDate, NoTickets, BookingTotal)  
VALUES(3, 1, 3, '2020-04-08' , 2, 30.00);
                                     
INSERT INTO Bookings (BookingID, CustID, EventID, BookingDate, NoTickets, BookingTotal)  
VALUES(4, 2, 1, '2020-04-08' , 6, 150.00);
                                     
INSERT INTO Bookings (BookingID, CustID, EventID, BookingDate, NoTickets, BookingTotal)  
VALUES(5, 2, 2, '2020-04-08' , 1, 35.00);
                                     
INSERT INTO Bookings (BookingID, CustID, EventID, BookingDate, NoTickets, BookingTotal)  
VALUES(6, 2, 3, '2020-04-08' , 2, 30.00);
                                     
INSERT INTO Bookings (BookingID, CustID, EventID, BookingDate, NoTickets, BookingTotal)  
VALUES(7, 3, 1, '2020-04-08' , 6, 150.00);
                                     
INSERT INTO Bookings (BookingID, CustID, EventID, BookingDate, NoTickets, BookingTotal)  
VALUES(8, 3, 4, '2020-04-08' , 7, 140.00);
                                     
INSERT INTO Bookings (BookingID, CustID, EventID, BookingDate, NoTickets, BookingTotal)  
VALUES(9, 3, 4, '2020-04-08' , 1, 20.00);

COMMIT;

