
Feature: cadastrar
	Como usuario do sistema
	Eu quero me registrar
	Para que eu possa acessar o sistema

	


Scenario Outline: Cadastrar Ususario
	Given que estou na pagina de cadastro 
	And eu preencho o campo nome <nome>
	And eu preencho o campo email <email>
	And eu preencho o campo nascimento <nascimento>
	And eu preencho o campo rg <rg>
	And eu preencho o campo celular<celular>
	And eu preencho o campo logradouro<logradouro>
	And eu preencho o campo numero<numero>
	And eu preencho o campo bairro<bairro>
	And eu preencho o campo complemento<complemento>
	And eu preencho o campo cep<cep>
	And eu preencho o campo uf <uf>
	And eu preencho o campo municipio <municipio>
	And eu preencho o campo cpf<cpf>
	And eu preencho o campo senha <senha>
	And eu preencho o campo repetir <repetir>
	And eu aceito o Termo de uso
	Then eu clico no botao Entrar

	
	Examples: 
	| nome             | email                 | nascimento | rg           | celular   | logradouro | numero | bairro    | complemento | cep      | uf          | municipio | cpf            | senha    | repetir  |
	| Lucas Vitor Dias | teste@teste.com.br | 04/11/1997 | 49.095.865-5 | 999666918 | Av.Florais | 875    | Ubirajara | Q.03        | 78048135 | Mato Grosso | Cuiabá    | 267.409.368-46 | lucas123 | lucas123 |