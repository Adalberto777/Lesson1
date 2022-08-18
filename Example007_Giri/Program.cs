int numberA = 1;
int numberB = 8;
int numberC = 3;
int numberD = 2;
int numberE = 6;

int max = numberA;

if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
if (numberD > max) max = numberD;
if (numberE > max) max = numberE;

Console.Write(max);