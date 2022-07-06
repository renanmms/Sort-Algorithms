#include <stdio.h>

// Bubble Sort
// Complexity O(n²)
void bubbleSort(int *v, int tam)
{
	int temp;
	
	for(int i = 0; i < tam; i++)
	{
		//printf("%d\n", v[i]);
		if(v[i] > v[i+1]){
			temp = v[i];
			v[i] = v[i+1];
			v[i+1] = temp;
		}
	}
}

int main()
{
	// Declarando um array
	int v[] = { 1, 10, 2, 3, 4, 5 };
	// Tamanho do array
	int tamanho = sizeof(v)/sizeof(int) - 1;

	// Procedimento para ordenar o array
	bubbleSort(v, tamanho);

	// Imprindo os elementos do array
	for(int i = 0; i < tamanho; i++)
	{	
		printf("%d ", v[i]);
	}

	//Caso esteja rodando o codigo no Windows descomentar a linha abaixo
	//system("pause");
	return 0;
}