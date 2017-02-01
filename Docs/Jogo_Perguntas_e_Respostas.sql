create database db_PerguntasERespostas

use db_PerguntasERespostas

create table tb_Jogador(
	id int identity primary key,
	nome varchar(100) not null
)

select * from tb_Jogador

insert into tb_Jogador(nome) values('Amanda')
insert into tb_Jogador(nome) values('Fernanda')
