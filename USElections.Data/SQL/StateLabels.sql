
DROP TABLE IF EXISTS StateBullets;

CREATE TABLE StateBullets (
	ID int NOT NULL PRIMARY KEY,
	GID int,
	labelx DECIMAL(8,4),
	labely DECIMAL(8,4),
	textx DECIMAL(8,4),
	texty DECIMAL(8,4),
	[Name] VARCHAR(512)
);

INSERT INTO StateBullets (id, gid, labelx, labely, textx, texty, [name]) VALUES
(1, 31, 909.5,168.625, 932,183,'NH')
,(2, 29, 860.5,228.625, 883,243,'VT')
,(3, 31, 909.5,258.625, 932,273,'RI')
,(4, 11, 860.5,258.625, 883,273,'NJ')
,(5, 14, 860.5,288.625, 883,303,'DE')
,(6, 12, 909.5,288.625, 932,303,'MD')
,(7, 13, 861.5,317.625, 884,332,'DC')
,(8, 55, 909.5,198.625, 932,213,'MA')
,(9, 32, 909.5,228.625, 932,243,'CT')
,(10, 6, 10,10, 289.05,550.625,'HI')

GO

select top 20 * from StateBullets




    