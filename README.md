# XPTO

Teste para a PUC-RJ em C#  leitura e escrita em arquivo TXT usando VS 2015

* Uso da Linguagem C#;
* Uso do Visual Studio 2015; 
* Uso da OOP.

Descrição da Solução XPTO.

Criação, leitura e escrita em arquivo TXT com a seguinte descrição técnica:

Início da programação: 16:00hs de 08.04.2018;
Término da programação: 04:00hs de 09.04.2018;
IDE: Visual Studio 2015 Enterprise;
Linguagem: C#;
Pattern: WindowsForm;
Interface: XptoInterface;
Classe: XptoClass;
Github: kariokabrs/XPTO;
Solução publicada ? Não;
CodeAnaylis? Yes;
Erros: 0

Utilização de Windows forms com 2 botões sendo:
 1 btn para ler um arquivo pre definido no teste e escrever em outro arquivo gerado com os digitos verificadores calculados.
 2 btn para ler um arquivo pre definido no teste e escrever em outro arquivo gerado com a verificação dos digitos verificadores se verdadeiros ou falsos. 

O programa usa uma Interface, XptoInterface,  para implementar os métodos sendo obrigados a possuirem na classe, XptoClass, classe iniciada no XptoForm com os seguintes métodos chamados:

 1 GerarDv - gera um arquivo, com buffer de 128 para performance para escrita no caminho c:\Temp com o nome conforme requerido do teste, lê um arquivo pré definido pelo teste e salvo na pasta Arquivo da Solução XPTO linha por linha em formato de String para posterior divisão em um array int no método estático , DividirDigitos, para cálculos e geração do digitor verificar em hexadecimal.
 2 VerificarDV - gera um arquivo com buffer de 128 para performance para escrita no caminho c:\Temp com o nome requerido no teste , lê um arquivo pré definido pelo teste e salvo na pasta Arquivo da Solução XPTO linha por linha em formato de String para posterior divisão em um array int no método estático , DividirDigitos, para cálculos e geração do digitor verificar em hexadecimal.

obs: Visto as matrículas podem iniciar com 0 em seus números até 9999, foi usado o método PadLeft para incluir um zero à esquerda visto na conversão da String para um Int o 0 precedente é perdido. Com isso os dígitos trasnformados sempre ficam com 4 digítos. 

Atencisoamente,

Sérgio Rezende
