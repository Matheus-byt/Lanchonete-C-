using System;

namespace Testing
{
    class Cadastro
    {
        static void Main()

        {

            float produto, unidades, pedido, valores;


            Console.WriteLine("###### OLÁ, SEJA MUITO BEM VINDO A LANCHONETE LANCHÃO #######\n");
            Console.WriteLine("\t               CARDÁPIO:           ");

            Console.WriteLine("\n CÓDIGO       LANCHE                PREÇO UNITÁRIO" +
                "\n #100         CACHORRO QUENTE       R$ 5.00" +
                "\n #101         BAURU SIMPLES         R$ 6.00" +
                "\n #102         BAURU COM OVO         R$ 7.00" +
                "\n #103         HAMBURGUER            R$ 6.00" +
                "\n #104         CHEESEBURGUER         R$ 8.00" +
                "\n #105         REFRIGERANTE          R$ 5.00");

            Console.WriteLine("\nESCOLHA UM PRODUTO DE ACORDO COM O CÓDIGO: ");
            produto = float.Parse(Console.ReadLine());
            Console.WriteLine("\nQUANTAS UNIDADES DO PRODUTO VOCÊ VAI COMPRAR?:  ");
            unidades = float.Parse(Console.ReadLine());


                if (produto == 100)
                {
                    valores = 5;
                    pedido = unidades * valores;
                    Console.WriteLine("O VALOR TOTAL DO SEU PEDIDO É: R$" + pedido);

                }

                if(produto == 101)
                {
                    valores = 6;
                    pedido = unidades * valores;
                    Console.WriteLine("O VALOR TOTAL DO SEU PEDIDO É: R$" + pedido);
                }

               if (produto == 102)
               {
                    valores = 7;
                    pedido = unidades * valores;
                    Console.WriteLine("O VALOR TOTAL DO SEU PEDIDO É: R$" + pedido);
               }

              if (produto == 103)
               {
                   valores = 6;
                   pedido = unidades * valores;
                   Console.WriteLine("O VALOR TOTAL DO SEU PEDIDO É: R$" + pedido);
              }

             if (produto == 104)
             {
                 valores = 8;
                 pedido = unidades * valores;
                 Console.WriteLine("O VALOR TOTAL DO SEU PEDIDO É: R$" + pedido);
             }

            if (produto == 105)
            {
                valores = 5;
                pedido = unidades * valores;
                Console.WriteLine("\nO VALOR TOTAL DO SEU PEDIDO É: R$" + pedido);
            }

           if (produto > 105)
           {
                Console.WriteLine("Código inválido.");
           }

         }
       }
   }


