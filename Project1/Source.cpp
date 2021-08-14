#include <stdio.h>
#include <stdlib.h>

int main()
{
	int i, j, min = 0, a[100], size;
	printf("size");
	scanf_s("%d", &size);
	printf("enter the value");
	for (i = 0; i < size; i++)
	{
		scanf_s("%d", &a[i]);

		if (i == 0)
			min = a[i];

		if (min > a[i])
			min = a[i];
	}
	printf("%d", min);

	return 0;
}