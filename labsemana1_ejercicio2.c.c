#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	double num_usuario;
	int aux1 = 2;
	int aux2 = 10;
	int aux3 =7;
	
	printf("ingrese un numero, este se multiplicara por 2, sumara 10 y dividira por 7 \n");
	scanf("%lf", &num_usuario);
	
	
	num_usuario = num_usuario * aux1;
	num_usuario = num_usuario + aux2;
	num_usuario = num_usuario/aux3;
	
	printf("el numero terminara siendo %lf",num_usuario);
	
	
	return 0;
}
