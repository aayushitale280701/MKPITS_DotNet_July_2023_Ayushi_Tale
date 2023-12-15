Create table NobelWinner(YEARS int,
                        SUBJECTS varchar(50),
                        WINNER varchar(50),
                        COUNTRY varchar(20),
                        CATEGORY varchar(20))
insert into NobelWinner values (1970,' Physics','Hannes Alfven','Sweden','Scientist')
insert into NobelWinner values (1950,' Physics','Louis Neel ','France','Scientist')
insert into NobelWinner values (1970,' Chemistry','Luis Federico Leloir','France','Scientist')
insert into NobelWinner values (1970, 'Physiology','Ulf von Euler','Sweden','Scientist')
insert into NobelWinner values (1970,  ' Physiology','Bernard Katz','Germany','Scientist')
insert into NobelWinner values (1970,' Literature','Aleksandr Solzhenitsyn','Russia','Linguist')
insert into NobelWinner values (1970,' Economics','Paul Samuelson','USA','Linguist') 
Select WINNER,SUBJECTS from NobelWinner where YEARS='1950' 
