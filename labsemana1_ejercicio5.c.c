#include <stdio.h>
#include <stdlib.h>
#include <time.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	
	srand(time(NULL));
	int numeroActual = 1;
	int auxNumeroPrevio;
	char iniciar_juego = ' ';
	
	
	printf("Presione enter para iniciar a generar piezas de VRVTetrix");
	scanf("%c",&iniciar_juego);
	system("cls");
	
	
	while(iniciar_juego == '\n'){
		
		while(numeroActual == auxNumeroPrevio){
			numeroActual = rand()%7+1;
    	}
		
		printf("\n la pieza generada es la numero %d",numeroActual);
		
		auxNumeroPrevio = numeroActual;
		
		printf("\n si desea salir del juego ingrese cualquier valor si no presione enter");
		scanf("%c",&iniciar_juego);
		
		
	}
	
	
	
		
	
	
	
	
	
	
	
	
	return 0;
}
