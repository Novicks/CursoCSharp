using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Coleçoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancado;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação de Strings - Fundamentos", InterpolaçaoDeStrings.Executar},
                {"Notação Ponto - Fundamentos", NotaçaoPonto.Executar},
                {"Lendo Dados Consoles - Fundamentos", LendoDadosConsole.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversões.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmetricos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresDeAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternarios - Fundamentos", OperadorTernarios.Executar},

                // Estruturas De Controle
                {"Estrutura If - Estrutura de Controle", EstruturaIF.Executar}, 
                {"Estrutura If/Else - Estrutura de Controle", EstruturaIfElse.Executar}, 
                {"Estrutura If/Else/IF - Estrutura de Controle", EstruturaIfElseIf.Executar}, 
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar}, 
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar}, 
                {"Estrutura Do While - Estrutura de Controle", EstruturaDoWhile.Executar}, 
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar}, 
                {"Estrutura Foreach - Estrutura de Controle", EstruturaForEach.Executar}, 
                {"Usando Break - Estrutura de Controle", UsandoBreak.Executar}, 
                {"Usando Continue - Estrutura de Controle", UsandoContinue.Executar},
                
                // Classes e Metodoos
                {"Membros - Classes e Metodos", Membros.Executar}, 
                {"Construtores - Classes e Metodos", Construtores.Executar}, 
                {"Metodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar}, 
                {"Metodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar}, 
                {"Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar}, 
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar}, 
                {"Params - Classes e Metodos", Params.Executar}, 
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar}, 
                {"Getter & Setter - Classes e Metodos", GettersESetters.Executar}, 
                {"Propriedades - Classes e Metodos", Propriedades.Executar}, 
                {"Readonly - Classes e Metodos", Readonly.Executar}, 
                {"Exemplo Enum - Classes e Metodos", ExemploEnum.Executar}, 
                {"Struct - Classes e Metodos", Struct.Executar}, 
                {"Struct VS Classe - Classes e Metodos", StructVsClasse.Executar}, 
                {"Valor VS Referencia - Classes e Metodos", ValorVsReferencia.Executar}, 
                {"Parametros por Referencia - Classes e Metodos", ParametrosPorReferencia.Executar}, 
                {"Exemplos de Out - Classes e Metodos", ExemplosDeOut.Executar}, 
                {"Parametros Padrão - Classes e Metodos", ParametrosPadrao.Executar},
                
                // Coleções
                {"Usandoa Array - Coleções", UsandoArray.Executar}, 
                {"Coleções List - Coleções", ColecoesList.Executar}, 
                {"Coleções Array List - Coleções", ColecoesArrayList.Executar}, 
                {"Coleções Set - Coleções", ColecoesSet.Executar}, 
                {"Coleções Queue - Coleções", ColecoesQueue.Executar}, 
                {"Igualdade - Coleções", Igualdade.Executar}, 
                {"Stacks - Coleções", ColecoesStack.Executar}, 
                {"Dictionary - Coleções", ColecoesDictionary.Executar}, 

                // Orientação a Objetos
                {"Herança - Orientação a Objetos", Heranca.Executar}, 
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar}, 
                {"Encapsulamento - Orientação a Objetos", EncapsulamentoOO.Executar}, 
                {"Polimorfismo - Orientação a Objetos", Polimorfismo.Executar}, 
                {"Classes Abstract - Orientação a Objetos", Abstract.Executar}, 
                {"Interface - Orientação a Objetos", Interface.Executar}, 
                {"Sealed - Orientação a Objetos", Sealed.Executar},

                // Metódos e Funções
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambda Delegate - Métodos e Funções", LambdasDelegade.Executar},
                {"Usando Delegate - Métodos e Funções", UsandoDelegates.Executar},
                {"Delegate função anônima - Métodos e Funções", DelegateFunAnonima.Executar},
                {"Delegate Como Parâmetros - Métodos e Funções", DelegatesComoParametro.Executar},
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},

                // Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                {"Exceção Personalizadas - Exceções", ExcecaoPersonalizada.Executar},

                // Explorando API
                {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo Dados - Usando API", LendoArquivos.Executar},
                {"Usando FileInfo - Usando API", ExemploFileInfo.Executar},
                {"Usando Diretorios - Usando API", Diretorios.Executar},
                {"Usando DiretorioInfo - Usando API", ExemploDirectoryInfo.Executar},
                {"Usando Path - Usando API", UsandoPath.Executar},
                {"Usando DataTime - Usando API", UsandoDataTime.Executar},
                {"Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar},

                // Topicos Avançados
                {"LinQ #1 - Topicos Avançados", LINQ1.Executar},
                {"LinQ #2 - Topicos Avançados", LINQ2.Executar},
                {"Nulllables - Topicos Avançados", Nullables.Executar},
                {"Dinamicos - Topicos Avançados", Dynamics.Executar},
                {"Generics - Topicos Avançados", Genericos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}