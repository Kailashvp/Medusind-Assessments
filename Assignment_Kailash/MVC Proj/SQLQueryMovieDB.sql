create database MoviesDB;
use MoviesDB 
CREATE TABLE TamilMovies (
  Mid INT PRIMARY KEY,
  MovieName VARCHAR(255),
  DateOfRelease DATE
);

INSERT INTO TamilMovies (Mid, MovieName, DateOfRelease)
VALUES
  (001, 'Naalaiya Theerpu ', '1992-02-22'),
  (002, 'Love Today', '1977-02-22'),
  (003, 'Friends', '2001-02-22'),
  (004, 'Thirumalai ', '2003-02-22'),
  (005, 'Bigil', '2019-02-22'),
  (006, 'Vadachennai','2018-02-22'),
  (007, 'Ghilli','2004-02-22'),
  (008, 'Pokkiri','2007-02-22'),
  (009, 'Theri','2016-02-22'),
  (0010, 'Nanban ','2012-02-22')

select * from TamilMovies