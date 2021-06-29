/*
	txt file created at 24-06-2021 | 16:57:49
	txt file created by "Eduardo"
	txt file name "ReadMe"
*/

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Trabalho desenvolvido por:

Eduardo Amado . 2202420
João Fernandes . 2201158
Tiago Tavares . 2202418

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Instruções após download:
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Dentro do projeto:

Solution Explorer >> DA_BooKids.edmx.sql

--
Verificar a linha -11- de código : "USE [BooKids_DB]"
--

De seguida:


View >> SQL Server Object Explorer >> SQL Server >> (localdb)\MSSQLLocalDB.... >> Databases (Botão lado direito do rato na pasta Databases) >> "Add New Database"
 

Use o nome referido acima "BooKids_DB" (nome da base de dados a criar tem que ser exatamente igual ao referido)

No fim da criação da Database, volte a "DA_BooKids.edmx.sql" e corra o código

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Instruções contra erros:
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Um dos erros possivel de acontecer é o "Erro Fatal Desconhecido" (ocorrente na binding navigator(zona superior dos forms que serve como objetivo a inserção de dados numa tabela))


De forma a evitar este erro é aconselhado que quando quiser inserir uma nova row de dados em uma tabela apenas clique uma vez no + e não clique em mais nenhuma opção do navigator
(se clicar duas vezes seguidas no + , na bindingNavigator, o "Erro Fatal Desconhecido" irá lhe ser demonstrado)
Após clicar no + apenas preencha os campos em branco, no fim do preenchimento clicar no botao "save" no bindingnavigator para adicionar dados a uma tabela

-------------------------------------------------------------------------------------------------------------------------------------------------------------------
Outro erro capaz de acontecer é o "Erro ao Gravar" (ocorrente ao salvar dados numa tabela)

Já que grande parte das ocorrências a este erro foram devidas ao preenchimento de chaves estrangeiras aonde a chave primaria era inexistente em outras tabelas 
é lhe, de forma a evitar este erro, aconselhado a certificar se a chave estangeira que está prestes a preencher existe como chave primária em outra entidade.