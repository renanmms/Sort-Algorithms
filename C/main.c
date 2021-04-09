#include <stdio.h>

void bubbleSort(int *v, int tam)
{
	//printf("%d", v[sizeof(v)/sizeof(int) - 1]);
	for(int i = 0; i <= tam; i++)
	{
		//printf("%d\n", v[i]);
	}
}

int main()
{
	int v[] = { 1, 10, 2, 3, 4, 5 };
	int tamanho = sizeof(v)/sizeof(int) - 1;
	//printf("%d", bubbleSort(v));
	bubbleSort(v, tamanho);

	//Caso esteja rodando o codigo no Windows descomentar a linha abaixo
	//system("pause");
	return 0;
}