CREATE TABLE [dbo].[Hotels] (
    [hotelID]        VARCHAR (50)  NOT NULL,
    [hotelName]      VARCHAR (50)  NOT NULL,
    [noOfRooms]      INT           DEFAULT ((5)) NOT NULL,
    [location]       VARCHAR (100) NOT NULL,
    [facilities]		 INT           NULL,
    PRIMARY KEY CLUSTERED ([hotelID] ASC),
	CHECK ([facilities] IN (0,1,2,3)),
    CONSTRAINT [UQ_HotelName] UNIQUE NONCLUSTERED ([hotelName] ASC)
);

