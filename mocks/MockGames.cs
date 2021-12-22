using SHOP.interfaces;
using SHOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP.mocks
{
    public class MockGames : Iallgames
    {
        private readonly IgamesCategory _categoryGames = new MockCategory();




        public IEnumerable<game> Games {
            get
            {
                return new List<game> {
                    new game {
                        name = "Dota 2",
                        shortDesc ="Командная игра в жанре MOBA",
                        longdesc = "Компьютерная многопользовательская командная игра жанра стратегия в реальном времени с элементами компьютерной ролевой игры, реализация известной карты DotA для игры Warcraft III в отдельном клиенте.",
                        img = "/img/dota 2.jpg",
                        price =1000,
                        isFavourite =true,
                        avaible= true,
                        Category = _categoryGames.ALLcategories.First()
                },
                new game
                {
                    name = "Dead By Daylight",
                    shortDesc = "Action, Survival horror",
                    longdesc = "Тема для выработки адреналина, казалось бы, тривиальна – маньяки и жертвы, однако преподнесена она довольно нестандартно. Этакие себе «кошки-мышки». Уникальность мультиплеерного проекта в том, что душегубом в нем выступает не бездушный АИ с неповоротливыми мозгами, а игрок, то есть вполне живой и здравомыслящий человек. Так что пощады и просчитываемых ходов изначально не будет, в чем быстро убедятся те, кто решит купить Dead by Daylight.",
                    img = "/img/dbd.jpg",
                    price = 550,
                    isFavourite = false,
                    avaible = true,
                    Category = _categoryGames.ALLcategories.First()
                },
                new game
                {
                    name = "For Honor",
                    shortDesc = "Action/Fighting",
                    longdesc = "Гигантские армии, в составе которых выступают и живые игроки, сходятся в смертельном противостоянии. Земля сотрясается от топота сотен ног, уши закладывает от звона металла, и вот уже кто-то падает, пронзенный стрелой, а огромный снаряд, очередной раз выпущенный из катапульты, наконец-то проламывает ворота и начинается грандиозный штурм замка…",
                    img = "/img/for honor.jpg",
                    price = 625,
                    isFavourite = true,
                    avaible = false,
                    Category = _categoryGames.ALLcategories.First()
                },
                new game
                {
                    name = "Escape from tarkov",
                    shortDesc = "Action/RPG",
                    longdesc = "Многопользовательская ролевая онлайн-игра от первого лица, разрабатываемая компанией Battlestate Games, сочетающая в себе жанры FPS и RPG c ММО-элементами. Разработчиком и издателем «Побега из Таркова» выступает российская компания Battlestate Games.",
                    img = "/img/tarkov.jpg",
                    price = 1600,
                    isFavourite = true,
                    avaible = true,
                    Category = _categoryGames.ALLcategories.First()
                },
                new game
                {
                    name = "Forza Horizon 5",
                    shortDesc = "Гоночная игра, Симулятор",
                    longdesc = "Вас ждёт бесконечный калейдоскоп приключений Horizon! Совершайте увлекательные поездки по невероятно красивому и самобытному миру Мексики за рулём величайших автомобилей в истории",
                    img = "/img/horizon.jpg",
                    price = 3000,
                    isFavourite = false,
                    avaible = true,
                    Category = _categoryGames.ALLcategories.First()
                },
                new game
                {
                    name = "Half-life 3",
                    shortDesc = "Шутер от первого лица, фэнтези",
                    longdesc = "Компьютерная игра, научно-фантастический шутер от первого лица, сиквел Half-Life, разработанный компанией Valve, издаваемый ими же и Sierra Entertainment. Игра была выпущена в 2004 году, получила всеобщее признание и собрала множество наград и более 45 титулов «Игра года 2004».",
                    img = "/img/hf2.jpg",
                    price = 350,
                    isFavourite = true,
                    avaible = true,
                    Category = _categoryGames.ALLcategories.Last()
                },
                new game
                {
                    name = "Max Payne",
                    shortDesc = "Шутер от третьего лица, Action-adventure",
                    longdesc = "Компьютерная игра в жанре шутера от третьего лица, разработанная финской компанией Remedy Entertainment, спродюсированная 3D Realms и изданная Gathering of Developers в 2001 году. Это первая часть в серии Max Payne.",
                    img = "/img/max.jpg",
                    price = 400,
                    isFavourite = false,
                    avaible = false,
                    Category = _categoryGames.ALLcategories.Last()
                },
                new game
                {
                    name = "DOOM 2016",
                    shortDesc = "Шутер от первого лица, Survival horror",
                    longdesc = "Мультиплатформенная компьютерная игра в жанре шутера от первого лица. Разработана компанией id Software совместно со студией Certain Affinity и издана Bethesda Softworks. Игра вышла на Windows, Xbox One и PlayStation 4 13 мая 2016 года.",
                    img = "/img/doom.jpg",
                    price = 1000,
                    isFavourite = true,
                    avaible = true,
                    Category = _categoryGames.ALLcategories.Last()
                },
                new game
                {
                    name = "Hitman 2",
                    shortDesc = "Стелс, Шутер, Квест",
                    longdesc = "Компьютерная игра 2018 года в жанре стелс-экшена, разработанная датской студией IO Interactive и изданная Warner Bros. Interactive Entertainment. Седьмая игра серии Hitman. Игра заявлена как 2-й сезон и является прямым продолжением игры 2016 года.",
                    img = "/img/hitman.jpg",
                    price = 1400,
                    isFavourite = false,
                    avaible = true,
                    Category = _categoryGames.ALLcategories.Last()
                },
                new game
                {
                    name = "Dark Souls",
                    shortDesc = "Action/RPG, Action-adventure",
                    longdesc = "Компьютерная игра в жанре action/RPG с открытым миром, разработанная японской компанией From Software и выпущенная в 2011 году для PlayStation 3 и Xbox 360. В Японии издателем игры выступала сама From Software; на международном рынке игру издавала компания Namco Bandai Games.",
                    img = "/img/ds 1.jpg",
                    price = 1200,
                    isFavourite = true,
                    avaible = true,
                    Category = _categoryGames.ALLcategories.Last()
                }
            };   
                
        }


    }
        public IEnumerable<game> getFavgames {get; set;}
        

        public game getObjectGame(int gameid)
        {
            throw new NotImplementedException();
        }
    }
}
