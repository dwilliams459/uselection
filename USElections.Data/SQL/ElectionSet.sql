

TRUNCATE TABLE ElectionSets
GO

DROP TABLE IF EXISTS ElectionSets
GO

CREATE TABLE ElectionSets (
    ID	INT NOT NULL,
    [Year] INT NOT NULL,
    Republican varchar(50),
    Democrat  varchar(50),
    RepublicanStates Varchar(250),
    DemocratStates Varchar(250)
);

INSERT INTO USStates (GID, [Name], electors, bulletx, bullety, labelx, labely, Fill, Stroke, Path, Class, Opacity, strokeOpacity, strokeWidth, strokeLinejoin, transform, style, FillOpacity) VALUES
 
GO

select top 10 * from usstates