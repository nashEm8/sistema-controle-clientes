## Sistema de controle de clientes 📊​

Neste projeto, vou colocar em prática conceitos da linguagem C# e também dos pilares da orientação a objetos para construir um sistema de controle de clientes baseado no seguinte diagrama:  <br/><br/>

<p align="center">
  <img src="https://github.com/user-attachments/assets/266af7b3-93b7-45fd-896e-267dcdf4fbae"/>
</p>


## 1️⃣​ Funcionalidades
Ao analisar o diagrama, é preciso que o sistema corresponda aos seguintes requisitos: 
- *a entrada de dados deve ser informada via console e informado pelo usuário;*
- *o sistema deve ser inteiramente baseado em conceitos de POO (Abstração, Herança, Polimorfismo e Encapsulamento);*
- *a cada execução o sistema deverá informar se o cliente é pessoa física ou jurídica;*
- *o cálculo de imposto deve corresponder ao determinado tipo de cliente;*
- *os dados do clientes e o resultado dos cálculos devem ser apresentados na tela;*

## 2️⃣​ Análise de Diagrama
Os clientes podem ser pessoa física (com CPF e RG) ou pessoa jurídica (com CNPJ e Inscrição Estadual). <br/><br/>
O diagrama de classes, então, mostra que a classe **Clientes** é a classe pai das subclasses **PessoaFisica** e **PessoaJuridica**. Os atributos e métodos da classe-pai são herdados por ambas as classes-filhas. <br/><br/>
A classe **PessoaFisica** tem, ainda, os atributos específicos **CPF** e **RG**, e a classe **PessoaJuridica** tem os atributos específicos **CNPJ** e **IE**. <br/><br/>
O imposto para pessoa física é de 10% sobre o valor e, para pessoa jurídica, é 20%; e 90% dos clientes são pessoas físicas. <br/><br/>
O método **Pagar_Imposto** da classe-pai **Clientes** é reescrito(**override**) na classe **PessoaJuridica**, devido ao percentual diferente de imposto a ser pago.

## 3️⃣​ Resultado
| ![Imagem 1](https://github.com/user-attachments/assets/f036443b-6c7c-43a6-aae6-4e7335e456f6) | ![Imagem 2](https://github.com/user-attachments/assets/645f4e79-11eb-421a-b35c-24225fdac615) |
|------------------------------|------------------------------|
| Dados do cliente Pessoa Física        | Dados do cliente Pessoa Jurídica         |



### ​4️⃣​​ Ferramentas Utilizadas

* C#
* DotNet (SDK)
* Extensão para C#
