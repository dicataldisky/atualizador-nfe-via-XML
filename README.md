# Atualizador de Data e Hora pelo Arquivo NF-e "XML"

Atualizador de data e hora de uma tabela especifica do banco de dados SQL SERVER com base no diretório de arquivos XML

## Telas
<div align="center" style="float: left">
<img alt="TELA 1" width="180" src="https://user-images.githubusercontent.com/26310007/29761142-2b9c675e-8b9e-11e7-92ba-175993e8bdba.png" />
<img alt="TELA 2" width="180" src="https://user-images.githubusercontent.com/26310007/29761143-2bb85cb6-8b9e-11e7-983b-b4a4e13774fe.png" />
<img alt="TELA 3" width="180" src="https://user-images.githubusercontent.com/26310007/29761145-2bcecbae-8b9e-11e7-8bef-196843c9bd2c.png" />
<img alt="TELA 4" width="180" src="https://user-images.githubusercontent.com/26310007/29761144-2bcdc7ae-8b9e-11e7-8674-e5a487f22872.png" />
</div>


## O que é isso?

O _Atualizador de Data E Hora pelo Arquivo XML_ é uma aplicação escrita na linguagem CSharp via Windows Form Application utilizando SOMENTE bibliotecas nativas .NET Framework 4.5.

## Como funciona?

O atualizador lê todos os arquivos 'NF-e' em formato XML do diretório especificado e após a leitura de todos os arquivos válidos do tipo 'NF-e' o mesmo após confirmação realiza uma atualização na base de dados `SQL SERVER` informada linha por linha.

## Do que eu preciso?

- Windows 7 ou superior.

# Observações:
- Deseja executar o programa sem compilar?  
_/dist/Atualizador NF-e.exe_

- APOS CLICAR NO BOTÃO `Iniciar Atualização` (Processo 4) O PROCEDIMENTO É IRREVERSIVEL!

### Parâmetros
Durante o processo de preparação será necessário informar alguns campos de configuração no próprio programa:

| Campo                   | Obrigatório        | Descrição                                                     |
|-------------------------|--------------------|---------------------------------------------------------------|
| `String de Conexão`     | :white_check_mark: | String de Conexão duvidas? https://www.connectionstrings.com/ |
| `Tabela NFe`            | :white_check_mark: | Tabela da base de dados. (Aonde as notas se encontram salvas) |
| `Coluna Data e Hora`    | :white_check_mark: | Coluna datetime aonde é salvo a data e hora das notas         |
| `Coluna Chave de Acesso`| :white_check_mark: | Coluna aonde contenha a chave de acesso das notas             |
| `Tempo de cada Query`   | :ballot_box_with_check: | Informar tempo de execução em MILISSEGUNDOS Padrão: 350  |

# Observações:

- Somente realize o processo de atualização após a realização de um BACKUP de segurança.
- O PROCESSO DE ATUALIZAÇÃO É IRREVERSÍVEL!

## Disclaimer

Desenvolvido por D.A.C Soluções
Diego Ansanello Cataldi
contato@dacsistemas.com.br
