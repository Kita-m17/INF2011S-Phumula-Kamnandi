CREATE TABLE [dbo].[RoomAllocation]
(
	[roomID] VARCHAR(50) NOT NULL , 
    [bookingID] VARCHAR(50) NOT NULL, 
    [roomAllocationID] NCHAR(10) NOT NULL, 
    PRIMARY KEY ([roomAllocationID]), 
    
)
