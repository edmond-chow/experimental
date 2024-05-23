#include <iostream>
#include <string>
#include <SFML/Graphics.hpp>
int main()
{
    sf::RenderWindow window(sf::VideoMode(512, 512), "Gomoku", sf::Style::Close | sf::Style::Titlebar);
    while (window.isOpen())
    {
        sf::Event e;
        while (window.pollEvent(e))
        {
            switch (e.type)
            {
            case sf::Event::Closed:
                window.close();
                break;
            case sf::Event::EventType::MouseButtonReleased:
                std::cout << e.mouseButton.x << "    " << e.mouseButton.y << std::endl;
                break;
            default:
                break;
            }
        }
    }
    return EXIT_SUCCESS;
};