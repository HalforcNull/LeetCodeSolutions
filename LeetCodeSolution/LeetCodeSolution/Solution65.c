int ASCIITab = 9;
int ASCIISPACE = 32;
int ASCIISUBTRACT = 45;
int ASCIIDOT = 46;
int ASCIIDIGITMIN = 48;
int ASCIIDIGITMAX = 57;
int STRINGEND = 0;


bool isNumber(char* s) {
	bool headerChecking = false;
	bool bodyProcess = false;
	bool endProcess = false;

	bool bodyMeetDigit = false;
	bool bodyMeetE = false;
	bool bodyMeetDot = false;


	int i = -1;
	char current;
	while (true)
	{
		i++;
		current = s[i];

		if (current == 0)
		{
			return bodyMeetDigit;
		}

		if (headProcess && (current == 9 || current == 32))
		{
			continue;
		}

		if (headProcess && current == 45)
		{
			headProcess = false;
			bodyProcess = true;
			continue;
		}

		if (headProcess && current > 48 && current < 57)
		{
			headProcess = false;
			bodyProcess = true;
			bodyMeetDigit = true;
			continue;
		}

		if (bodyProcess && current > 48 && current < 57)
		{
			bodyMeetDigit = true;
			continue;
		}

		if (bodyProcess&&bodyMeetDigit && (current == 69 || current == 145))
		{
			if (bodyMeetE)
			{
				return false;
			}
			else
			{
				if (s[i + 1] == 45)
				{
					i++;
				}
				bodyMeetE = true;
				continue;
			}
		}

		if (bodyProcess&&bodyMeetDigit && current == 46)
		{
			if (bodyMeetDot)
			{
				return false;
			}
			else
			{
				bodyMeetDot = true;
				continue;
			}
		}

		if (bodyProcess && (current == 9 || current == 32))
		{
			bodyProcess = false;
			endProcess = true;
			continue;
		}

		if (endProcess)
		{
			if ((current == 9 || current == 32))
			{
				continue;
			}
			else
			{
				return false;
			}
		}


	}


	return true;
}


int headerCheck(char * s)
{
	int i = 0;
	while (true)
	{
		if (s[i] == STRINGEND)
		{
			return -1;
		}

		if (s[i] == ASCIISPACE)
		{
			i++;
			continue;
		}

		if (s[i] == ASCIISUBTRACT)
		{
			return i++;
		}

		if (s[i] >= ASCIIDIGITMIN && s[i] <= ASCIIDIGITMAX)
		{
			return i;
		}

		return -1;
	}
}

int numCheck(char * s, int i)
{
	i = baseCheck(s, i);
	if (i < 0)
	{
		return i;
	}

	return expCheck(s, i);
}

int expCheck(char * s, int i)
{
	if (s[i] == ASCIISUBTRACT)
	{
		i++;
	}

	return intCheck(s, i);
}

int baseCheck(char * s, int i)
{
	i = intCheck(s, i);
	if (i<0)
	{
		return i;
	}

	if (s[i] == ASCIIDOT)
	{
		i++;
		return intCheck(s, i);
	}
	else
	{
		return i;
	}
}

int intCheck(char * s, int i)
{
	if (!fullDigitPreCheck(s, i))
	{
		return -1;
	}
	i++;
	return fullDigitTailCheck(s, i);
}

bool fullDigitPreCheck(char * s, int i)
{
	if (s[i] >= ASCIIDIGITMIN && s[i] <= ASCIIDIGITMAX)
	{
		return true;
	}
	else { return false; }
}

int fullDigitTailCheck(char *s, int i)
{
	while (true)
	{
		if (s[i] >= ASCIIDIGITMIN && s[i] <= ASCIIDIGITMAX)
		{
			i++;
			continue;
		}
		else
		{
			return i;
		}
	}
}


