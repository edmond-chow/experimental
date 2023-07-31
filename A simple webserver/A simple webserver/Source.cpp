#define _CRT_SECURE_NO_WARNINGS
#define _WINSOCK_DEPRECATED_NO_WARNINGS
#include <iostream>
#include <string>
#include <fstream>
#include <WinSock2.h>
std::string urlDecode(const std::string& SRC) {
    std::string ret;
    char ch;
    int i, ii;
    for (i = 0; i < SRC.length(); i++) {
        if (SRC[i] == '%') {
            int iii = sscanf(SRC.substr(i + 1, 2).c_str(), "%x", &ii);
            ch = static_cast<char>(ii);
            ret += ch;
            i = i + 2;
        }
        else {
            ret += SRC[i];
        }
    }
    return (ret);
}
int main(int argc, char** argv)
{
    std::cout << "Attempting to create a server.\n";
    WSADATA wsaData{ 0 };
    if (WSAStartup(MAKEWORD(2, 2), &wsaData) != 0)
    {
        std::cout << "Failed to start the server.\n";
        return EXIT_FAILURE;
    }
    SOCKET serverSocket = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);
    if (serverSocket == INVALID_SOCKET)
    {
        std::cout << "Failed to create a socket for the server.\n";
        return EXIT_FAILURE;
    }
    sockaddr_in serverAddr{ 0 };
    serverAddr.sin_family = AF_INET;
    serverAddr.sin_addr.s_addr = inet_addr("127.0.0.1");
    serverAddr.sin_port = htons(8080);
    int serverAddrLen = sizeof(sockaddr_in);
    if (bind(serverSocket, reinterpret_cast<SOCKADDR*>(&serverAddr), serverAddrLen) != 0)
    {
        std::cout << "Failed to bind an address for the server.\n";
        return EXIT_FAILURE;
    }
    if (listen(serverSocket, 20) != 0)
    {
        std::cout << "Failed to listen on an address for the server.\n";
        return EXIT_FAILURE;
    }
    std::cout << "listening on 127.0.0.1:8080.\n\n";
    SOCKET clientSocket{ 0 };
    while (true)
    {
        clientSocket = accept(serverSocket, reinterpret_cast<SOCKADDR*>(&serverAddr), &serverAddrLen);
        if (clientSocket == INVALID_SOCKET) {
            std::cout << "Failed to accept any requests from the client.\n";
        }
        int requestHeaderSize = 40960;
        char* requestHeader = new char[requestHeaderSize] { 0 };
        std::string requestHeaderString(requestHeader);
        int bytes = recv(clientSocket, requestHeader, requestHeaderSize, 0);
        if (bytes < 0) {
            std::cout << "Failed to read a request of the client.\n";
        }
        std::cout << "Request headers:\n\n" << requestHeader;
        std::string hostPath;
        std::size_t size{ 4 };
        while (strlen(requestHeader) != 0 && requestHeader[size] != ' ')
        {
            hostPath += requestHeader[size];
            ++size;
        }
        hostPath = urlDecode(hostPath);
        std::ifstream fileStream;
        std::string executionPath = argv[0];
        executionPath = executionPath.substr(0, executionPath.find_last_of("\\"));
        if (hostPath.find_last_of("/") + 1 == hostPath.length()) {
            hostPath += "index.html";
        }
        std::string fullPath = executionPath + hostPath;
        std::string contentType;
        if (hostPath.substr(hostPath.length() - 5) == ".html") {
            contentType = "text/html; charset=utf-8";
        }
        else if (hostPath.substr(hostPath.length() - 4) == ".css") {
            contentType = "text/css; charset=utf-8";
        }
        else if (hostPath.substr(hostPath.length() - 3) == ".js") {
            contentType = "application/javascript; charset=utf-8";
        }
        else if (hostPath.substr(hostPath.length() - 4) == ".png") {
            contentType = "image/png";
        }
        else if (hostPath.substr(hostPath.length() - 4) == ".jpg" || hostPath.substr(hostPath.length() - 5) == ".jpeg") {
            contentType = "image/jpeg";
        }
        else if (hostPath.substr(hostPath.length() - 4) == ".pdf") {
            contentType = "application/pdf; charset=utf-8";
        }
        FILE* file = fopen(fullPath.c_str(), "rb");
        std::string response = "HTTP/1.1 404";
        if (file == nullptr) {
            send(clientSocket, response.c_str(), static_cast<int>(response.size()), 0);
        }
        else
        {
            fseek(file, 0L, SEEK_END);
            long length = ftell(file);
            fseek(file, 0L, SEEK_SET);
            response = "HTTP/1.1 200 OK\nContent-Type: " + contentType + "\nContent-Length: " + std::to_string(length) + "\n\n";
            char* fileContentArray = new char[response.size() + length] { 0 };
            memcpy(fileContentArray, response.c_str(), response.size());
            fread(&fileContentArray[response.size()], 1, length, file);
            int totalSent = 0;
            int totalLength = static_cast<int>(response.size()) + length;
            while (totalSent < totalLength)
            {
                int sent = send(clientSocket, fileContentArray, totalLength, 0);
                if (sent < 0) {
                    std::cout << "Failed to send a response to the client.\n";
                }
                totalSent += sent;
            }
            fclose(file);
            delete[] fileContentArray;
        }
        sockaddr_in clientAddr{ 0 };
        int clientAddrLen = sizeof(sockaddr_in);
        getpeername(clientSocket, reinterpret_cast<sockaddr*>(&clientAddr), &clientAddrLen);
        std::cout << "Sent a response to " << inet_ntoa(clientAddr.sin_addr) << ":" << clientAddr.sin_port << ".\n\n";
        delete[] requestHeader;
        closesocket(clientSocket);
    }
    closesocket(serverSocket);
    WSACleanup();
    return EXIT_SUCCESS;
};