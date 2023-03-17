#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	
	int variable1 = 2;
	char variable2 = 'a';
	float variable3 = 3.33;
	double variable4 = 0;
	
	
 	printf("Ingrese una letra que represente la variable");
 	
 	printf("\n esta variable sera la respuesta de dividir %f en %d \n",variable3,variable1);
 	
 	scanf("%c", &variable2);

	variable4 = variable3/variable1;
	
	printf("\n la variable %c tiene un valor de %f ",variable2,variable4);
	
	
	
	
	return 0;
}
