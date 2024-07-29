#Solução Eduarda Neves Dmasceno Silva
Case para Engenharia de Software JR

Aplicação só está processando o primeiro item da fila infinitamente.

Solução:
Usei Dequeue em vez de Peek para remover o item da fila após o processamento, garantindo que cada item seja processado e removido corretamente.

Implemente a funcionalidade de divisão.

Solução:
Adicionei o método para realizar a divisão, convertendo os valores para decimal para garantir precisão nos cálculos.
Aplicação não está calculando a penúltima operação corretamente.

Solução:
Alterei o tipo dos valores de int para long para suportar valores maiores e corrigir o cálculo incorreto da penúltima operação.

Implemente uma funcionalidade para imprimir toda a lista de operações a ser processada após cada cálculo realizado.

Solução:
Adicionei uma funcionalidade para imprimir a lista de operações restantes na fila após cada cálculo.

Crie uma nova pilha (Stack) para guardar o resultado de cada cálculo efetuado e imprima a pilha ao final.

Solução:
Usei uma pilha para armazenar os resultados dos cálculos e implementei uma funcionalidade para exibir a pilha ao final na ordem correta.

Saida:
      
      2 + 3 = 5

      Operações restantes na fila:
      14 - 8
      5 * 6
      2147483647 + 2
      18 / 3
      
      14 - 8 = 6
      
      Operações restantes na fila:
      5 * 6
      2147483647 + 2
      18 / 3
      
      5 * 6 = 30
      
      Operações restantes na fila:
      2147483647 + 2
      18 / 3
      
      2147483647 + 2 = 2147483649
      
      Operações restantes na fila:
      18 / 3
      
      18 / 3 = 6
      
      Operações restantes na fila:
      
      Resultados na pilha:
      2 + 3 = 5
      14 - 8 = 6
      5 * 6 = 30
      2147483647 + 2 = 2147483649
      18 / 3 = 6


# Calculadora
Case para Engenharia de Software JR

Você precisa corrigir os seguintes problemas no codigo:
  1. Aplicação só está processando o primeiro item da fila infinitamente.
  2. Implemente a funcionalidade de divisão.
  3. Aplicação não está calculando a penultima operação corretamente.
     
     	Saída esperada no console:
     
     		14 - 8 = 6
     
     		5 * 6 = 30
     
     		2147483647 + 2 = 2147483649
     
     		18 / 3 = 6

  5. Implemente uma funcionalidade para imprimir toda a lista de operaçõoes a ser processada após cada calculo realizado.
  6. Crie uma nova pilha (Stack) para guardar o resultado de cada calculo efetuado e imprima a pilha ao final


Não existe resposta certa ou errada, o objetivo do case é avaliar a linha de raciocínio de cada candidato.
Você é livre para fazer na linguagem de sua preferência, desde que aplique as mesmas funcionalidades e tarefas deste case.
Dica: Utilize Visual Code ou Visual Studio Community para realizar as tarefas.
