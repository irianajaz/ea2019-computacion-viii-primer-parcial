create database udo;
use udo;

create table `users` (
	`id` int auto_increment primary key,
	`name` varchar(20) not null unique,
	`passwd` varchar(200) not null,
	`firstname` varchar(50) not null,
	`lastname` varchar(50) not null,
	`email` varchar(200) not null,
	`remember_token` varchar(200) default null,
	`created_at` timestamp default current_timestamp
) engine=myisam charset=utf8 collate=utf8_general_ci;

insert into users (name,passwd,firstname,lastname,email)
values ('admin',sha('123'),'Administrador','Del Sistema','admin@sistema');

select * from users;