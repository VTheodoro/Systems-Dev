using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_exemplo_encapsulamento
{
    class aluno
    {
    private string nome;
        //regra para cada atributo deverá ter dois métodos publicos.

        //1º método - armazena:
        //esse método é sem retorno, por isso possui a palavra VOID e não tem o return.
        public void setNome(string nome)
        {
            //o nome do método deve ser set + o nome do atributo com a primeira letra em maiusculo (setNome).
            //set seve para recener valores digitados pelo usuário.
            //os valores digitados pelo usuário são armazenados no parametro (stringn nome) e repacssados para o atributo.
            this.nome = nome;
            //this significa "este", que diferencia o string nome do parametro do string nome privado la de cima.
        }
        
        //2º método - retorna:
        //método com retorno, o tipo do método deve ser do mesmo tipo do atibuto que ele está ligado.
        //o nome do método devera ser get + o nome do atributo com a 1º letra em maiusuculo(getNome).
        //método get serve para mostrar valores ao usuário armazenados dentro do método set.
        public string getNome()
        {
            return this.nome;
        }

    }
}
