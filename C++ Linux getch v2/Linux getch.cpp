#include <unistd.h>
#include <termios.h>
char getch()
{
    fflush(stdout);
    char result{};
    termios captured{};
    tcgetattr(0, &captured);
    termios current = captured;
    current.c_lflag &= ~ICANON;
    current.c_lflag &= ~ECHO;
    current.c_cc[VTIME] = 0;
    current.c_cc[VMIN] = 1;
    tcsetattr(0, TCSANOW, &current);
    ssize_t count = read(0, &result, 2);
    if (count == 0 || count == -1) { result = EOF; }
    tcsetattr(0, TCSANOW, &captured);
    return result;
};