create database db_PerguntasERespostas

use db_PerguntasERespostas

create table tb_Jogador(
	id int identity primary key,
	nome varchar(100) not null
)

select * from tb_Jogador

insert into tb_Jogador(nome) values('Amanda')
insert into tb_Jogador(nome) values('Fernanda')

create table tb_Perguntas(
    id int identity primary key,
    pergunta varchar(max),
    resposta_correta varchar(max),
    id_jogador int,
    data    datetime default getdate()
    )
    alter table tb_perguntas add id_jogador int

    select * from tb_Perguntas	
    
    insert into tb_Jogador(pergunta, resposta_correta)
    values('Qual é a cor do limâo?','verde')
    
    select * from tb_Jogador
    
    --deleta um id especifico na tabela--
     
    delete from tb_Jogador where id = 5
    
    --insere um novo id na tabela--
    
    insert into tb_Jogador(nome) values('Ramón')
    
    --deleta dados da tabela--
    
    delete from tb_Jogador
   
    --limpa a tabela e zera o campo identity--
    
    truncate table tb_jogador
    
    
