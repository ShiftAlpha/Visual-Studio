create database WeatherApplication ;

Create table City(

City_id int identity(1,1) primary key,

City_name varchar(100)

);

create table weather(

Weather_ID int identity(1,1) primary key,

City_id int,

Dates date,

MinTemp int,

MaxTemp int,

Prec int,

Hum int,

WindS int

foreign key (City_id) references City(City_id)

);

 

create table Users(

Username varchar(100),

Passwords Varchar(8),

User_ID int identity(1,1) primary key

);

 

create table Favourite(

Fav_ID int identity(1,1) primary key,

Weather_ID int not null,

User_ID int not null,

foreign key (Weather_ID) references Weather(Weather_ID),

foreign key (User_ID) references Users(User_ID)

);