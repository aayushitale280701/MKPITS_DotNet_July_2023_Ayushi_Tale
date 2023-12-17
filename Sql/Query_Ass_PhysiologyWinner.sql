Create Table PhysiologyWinners (YEARS INT,
                             SUBJECTS  VARCHAR(100),                 
                             WINNER    VARCHAR(100),                                    
                             COUNTRY   VARCHAR(100),
                             CATEGORY  VARCHAR(100)
							 )

insert into PhysiologyWinners values (1975,' Physics','Hannes Alfven','Sweden','Scientist')
insert into PhysiologyWinners values (1970,'Physics','Louis Neel','France','Scientist')
insert into PhysiologyWinners values (1970,' Chemistry','Luis Federico Leloir','France','Scientist')
insert into PhysiologyWinners values (1970,'Physiology','Ulf von Euler','Sweden','Scientist')
insert into PhysiologyWinners values (1960 ,'Physiology','Bernard Katz','Germany','Scientist')
insert into PhysiologyWinners values (1970,' Literature','Aleksandr Solzhenitsyn','Russia','Linguist')
insert into PhysiologyWinners values (1970,' Economics','Paul Samuelson','USA','Scientist')

select YEARS,SUBJECTS,WINNER,COUNTRY,CATEGORY FROM PhysiologyWinners WHERE YEARS BETWEEN '1970' AND '1975'   
