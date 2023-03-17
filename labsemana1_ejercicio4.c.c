#include <stdio.h>
#include <stdlib.h>
#include <time.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	srand(time(NULL));
	char GRAN_GATO[3][3];
	int aux;	
	int i,j;
	int contX = 5;
	int contO = 4;
	
	
	printf("GRAN_GATO \n\n");
	
	
	for(i=0;i<3;i++){
		for(j=0;j<3;j++){
			aux = rand()%2+1;
			
			if(aux == 1 && contX>0){
			
				GRAN_GATO[i][j] = 'X';	
				contX--;
			}else{
				if(aux == 2 && contO>0){
					GRAN_GATO[i][j] = 'O';	
					contO--;
				}else{
				if(contX>0){
					GRAN_GATO[i][j] = 'X';	
					contX--;
				}else{
				if(contO>0){
					GRAN_GATO[i][j] = 'O';	
					contO--;
				}
			}
			}
				
			}
			
		}
		
	}
	
	
	for(i=0;i<3;i++){
		printf("\n");
		for(j=0;j<3;j++){
		
			printf("%c",GRAN_GATO[i][j]);	
			printf("  ");
			
		}	
	}
		
	
	
	
	
	
	
	
	
	
	
	return 0;
}
