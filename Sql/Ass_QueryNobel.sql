Create table NobelPrize(YEARS int,
                        SUBJECTS varchar(50),
                        WINNER varchar(50),
                        COUNTRY varchar(20),
                        CATEGORY varchar(20))
Insert into NobelPrize values(1970,'Physics','Hannes Alfven','Sweden','Scientist')  
Insert into NobelPrize values(1970,'Physics','Louis Neel','France','Scientist')
Insert into NobelPrize values(1970,'Chemistry','Luis Federico Leloir','France','Scientist')                        
Insert into NobelPrize values(1970,'Physiology','Ulf von Euler','Sweden','Scientist')                        
Insert into NobelPrize values(1970,'Physiology','Bernard Katz','Germany','Scientist')                        
Insert into NobelPrize values(1971,'Literature','Aleksandr Solzhenitsyn','Russia','Linguist')                        
Insert into NobelPrize values(1970,'Economics','Paul Samuelson','USA ','Scientist')
Select WINNER,SUBJECTS from NobelPrize Where YEARS='1971'