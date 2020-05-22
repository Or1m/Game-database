using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using UDBS.Oracle;
using UDBS;
using DaisORM.UDBS.Oracle;
using DaisORM.UDBS.oracle;

namespace DaisORM
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Test
            //Database db = new Database();
            //db.Connect();
            //Console.WriteLine("_______________\n");
            //Console.WriteLine("Connected: " + db.Connect());
            //Console.WriteLine("_______________\n");
            ////------------------------------------------------

            //UserTable userTable = new UserTable();
            //User user = new User("Testt", 'M', "Slovakia", new DateTime(1998, 11, 17), new DateTime(2010, 1, 1), "Test", "Testik", 1);

            //// Funkcia 6.1.a Registrácia používateľa 
            //userTable.registerNewUser(user);

            //// Funkcia 6.1.i Detail používateľa (varianta s nickom)
            //user = userTable.selectUserByNick("Testt");
            //Console.WriteLine(user.ToString());

            //// Funkcia 6.1.g Aktualizácia osobných údajov užívateľa
            //user.Gender = 'F';
            //userTable.updateUser(user);

            //// Funkcia 6.1.i Detail používateľa (varianta s id)
            //user = userTable.selectUserById(user.User_id);
            //Console.WriteLine(user.ToString());

            //// Funkcia 6.1.j Detail vlastného profilu používateľa (varianta s id)
            //user = userTable.selectUserByIdWithCategory(1);
            //Console.WriteLine(user.ToString() + "| Category name: " + user.Favorit_category.Name);

            //// Funkcia 6.1.j Detail vlastného profilu používateľa (varianta s nickom)
            //userTable.selectUserByNickWithCategory("Mirec");
            //Console.WriteLine(user.ToString() + "| Category name: " + user.Favorit_category.Name);

            //// Funkcia 6.1.e Zoznam používateľov
            //List<User> users = userTable.selectUsers();
            //foreach (User u in users)
            //{
            //    Console.WriteLine(u.ToStringHeader());
            //}

            //// Funkcia 6.1.c Odstránenie užívateľa
            //userTable.deleteUserById(user.User_id);

            //Console.WriteLine("Users done!\n");
            ////------------------------------------------------

            //ReviewerTable reviewerTable = new ReviewerTable();
            //Reviewer reviewer = new Reviewer("Test2", "Testik", 'M', "Slovakia", "Wortex", new DateTime(1999, 11, 17), new DateTime(2011, 1, 1));

            //// Funkcia 6.1.b Registrácia recenzenta 
            //reviewerTable.registerNewReviewer(reviewer);

            //// Funkcia 6.1.k Detail recenzenta
            //reviewer = reviewerTable.selectReviewer(30);
            //Console.WriteLine(reviewer.ToString());

            //// Funkcia 6.1.h Aktualizácia osobných údajov recenzenta 
            //reviewer.Gender = 'F';
            //reviewerTable.updateReviewer(reviewer);
            //Console.WriteLine(reviewer.ToString());

            //// Funkcia 6.1.l Detail vlastného profilu recenzenta
            //Reviewer reviewer2 = reviewerTable.selectReviewerByIdWithCategory(1);
            //Console.WriteLine(reviewer2.ToString() + "| Category name: " + reviewer2.Favorit_category.Name);

            //// Funkcia 6.1.f Zoznam recenzentov
            //List<Reviewer> reviewers = reviewerTable.selectReviewers();
            //foreach (Reviewer r in reviewers)
            //{
            //    Console.WriteLine(r.ToStringHeader());
            //}

            //// Funkcia 6.1.d Odstránenie recenzenta 
            //reviewerTable.deleteReviewerById(reviewer.Reviewer_id);

            //// Funkcia 6.4.d Zobrazenie obľúbených recenzentov užívateľa
            //User user2 = new User();
            //user2.Favorit_reviewers = reviewerTable.selectFavoritReviewers(1);
            //foreach (Reviewer r in user2.Favorit_reviewers)
            //{
            //    Console.WriteLine(r.ToStringHeader());
            //}

            //Console.WriteLine("Reviewers done!\n");
            ////------------------------------------------------

            //GameTable gameTable = new GameTable();
            //Game game = new Game("TestGame2", "blah", "Crytek", "PEGI 18");

            //// Funkcia 6.2.a Vloženie novej hry 
            //gameTable.insertNewGame(game);

            //// Funkcia 6.2.i Detail hry (varianta s id)
            //game = gameTable.selectGame(1);
            //Console.WriteLine(game.ToString());

            //// Funkcia 6.2.i Detail hry (varianta s menom hry)
            //game = gameTable.selectGamesByName("TestGame2").ElementAt(0);

            //// Funkcia 6.2.c Aktualizácia údajov o hre
            //game.Developer = "CD Project";
            //gameTable.updateGame(game);
            //Console.WriteLine(game.ToString());

            //// Funkcia 6.2.g Zoznam hier (varianta všetky)
            //List<Game> games = gameTable.selectGames();
            //foreach (Game g in games)
            //{
            //    Console.WriteLine(g.ToStringHeader());
            //}

            //// Funkcia 6.2.g Zoznam hier (varianta pre hry od určitého štúdia)
            //games = gameTable.selectGamesByDeveloper("Bioware");
            //foreach (Game g in games)
            //{
            //    Console.WriteLine(g.ToStringHeader());
            //}

            //// Funkcia 6.2.b Odstránenie hry
            //gameTable.deleteGameById(game.Game_id);

            //// Funkcia 6.4.b Zobrazenie obľúbených hier užívateľa
            //User user3 = new User();
            //user3.Favorit_games = gameTable.selectFavoritGames(1);
            //foreach (Game g in user3.Favorit_games)
            //{
            //    Console.WriteLine(g.ToStringHeader());
            //}

            //Console.WriteLine("Games done!\n");
            ////------------------------------------------------

            //CategoryTable categoryTable = new CategoryTable();

            //// Funkcia 6.2.d Vloženie novej kategórie 
            //categoryTable.insertNew("TestCategory");

            //// Pomocná funkcia, ktorá sa nenachádza v analýze
            //Category category = categoryTable.selectCategoryByName("TestCategory").ElementAt(0);
            //Console.WriteLine(category.ToString());

            //// Funkcia 6.2.f Aktualizácia kategórie 
            //category.Name = "TestCategory2";
            //categoryTable.update(category.Category_id, category.Name);
            //Console.WriteLine(category.ToString());

            //// Funkcia 6.2.h Zoznam kategórií
            //List<Category> categories = categoryTable.selectCategories();
            //foreach (Category c in categories)
            //{
            //    Console.WriteLine(c.ToString());
            //}

            //// Funkcia 6.2.e Odstránenie kategórie
            //categoryTable.deleteById(category.Category_id);

            //// Pomocná funkcia, ktorá sa nenachádza v analýze
            //category = categoryTable.selectCategory(1);
            //Console.WriteLine(category.ToString());

            ////  Funkcia 6.2.i Detail hry (varianta spolu s categoriamai do ktorých hra patrí)
            //Game game1 = new Game();
            //game1.Categories = categoryTable.selectCategoriesForGame(1);
            //foreach (Category c in game1.Categories)
            //{
            //    Console.WriteLine(c.ToString());
            //}

            //Console.WriteLine("Categories done!\n");
            ////------------------------------------------------

            //DailyStatisticsTable dailyStatisticsTable = new DailyStatisticsTable();

            //// Pomocná funkcia, ktorá sa nenachádza v analýze
            //List<DailyStatistics> dailys = dailyStatisticsTable.selectStatistics();
            //foreach (DailyStatistics st in dailys)
            //{
            //    Console.WriteLine(st.ToString());
            //}

            //// Pomocná funkcia, ktorá sa nenachádza v analýze
            //DailyStatistics ds = dailyStatisticsTable.selectStatisticById(4);
            //Console.WriteLine(ds.ToString());

            //Console.WriteLine("DailyStatistics done!\n");
            ////------------------------------------------------

            //GameCategoryTable gameCategoryTable = new GameCategoryTable();

            //// Pomocná funkcia, ktorá sa nenachádza v analýze
            //gameCategoryTable.insertNew(1, 3);

            //// Pomocná funkcia, ktorá sa nenachádza v analýze
            //gameCategoryTable.delete(1, 3);

            //Console.WriteLine("GameCategory done!\n");
            ////------------------------------------------------

            //FavoritReviewerTable favoritReviewerTable = new FavoritReviewerTable();

            //// Funkcia 6.4.c Pridanie recenzenta ako obľúbeného
            //favoritReviewerTable.insertNew(1, 3);

            //// Pomocná funkcia, ktorá sa nenachádza v analýze
            //favoritReviewerTable.delete(1, 3);

            //Console.WriteLine("FavoritReviewer done!\n");
            ////------------------------------------------------

            //FavoritGameTable favoritGameTable = new FavoritGameTable();

            //// Funkcia 6.4.a Pridanie hry ako obľúbenej
            //favoritGameTable.insertNew(3, 2);

            //// Pomocná funkcia, ktorá sa nenachádza v analýze
            //favoritGameTable.delete(3, 2);

            //Console.WriteLine("FavoritGame done!\n");
            ////------------------------------------------------

            //UserReviewTable userReviewTable = new UserReviewTable();
            //User_review user_Review = new User_review("Zle", 1, 8, 6, new DateTime(), 1);

            //// Funkcia 6.3.a Pridanie užívateľskej recenzie
            //// Funkcia 6.3.c Aktualizácia užívateľskej recenzie (aktualizovaná sa uloží ako nová s vyšším poradovým číslom)
            //userReviewTable.insertNew(user_Review);

            //// Funkcia 6.3.f Detail užívateľskej recenzie
            //user_Review = userReviewTable.selectReview(user_Review.UserId, user_Review.GameId, user_Review.Order_of_review);
            //Console.WriteLine(user_Review.ToString());

            //// Funkcia 6.3.b Odstránenie užívateľskej recenzie 
            //userReviewTable.delete(user_Review.UserId, user_Review.GameId, user_Review.Order_of_review);

            //// Funkcia 6.3.h Zoznam užívateľských recenzií
            //List<User_review> userReviews = userReviewTable.selectReviews();
            //foreach (User_review ur in userReviews)
            //{
            //    Console.WriteLine(ur.ToString());
            //}

            //// Funkcia 6.3.h Zoznam užívateľských recenzií (varianta pre užívateľa)
            //userReviews = userReviewTable.selectReviewsForUser(1);
            //foreach (User_review ur in userReviews)
            //{
            //    Console.WriteLine(ur.ToString());
            //}

            //// Funkcia 6.3.h Zoznam užívateľských recenzií (varianta pre hru)
            //userReviews = userReviewTable.selectReviewsForGame(1);
            //foreach (User_review ur in userReviews)
            //{
            //    Console.WriteLine(ur.ToString());
            //}

            //Console.WriteLine("UserReview done!\n");
            ////------------------------------------------------

            //ReviewerReviewTable reviewerReviewTable = new ReviewerReviewTable();
            //Reviewer_review reviewer_Review = new Reviewer_review("Zle", "Blah", 1, 2, 6, new DateTime(), 1);

            //// Funkcia 6.3.d Pridanie recenzentskej recenzie 
            //// Funkcia 6.3.e Aktualizácia recenzentskej recenzie (aktualizovaná sa uloží ako nová s vyšším poradovým číslom)
            //reviewerReviewTable.insertNew(reviewer_Review);

            //// Funkcia 6.3.g Detail recenzentskej recenzie 
            //reviewer_Review = reviewerReviewTable.selectReview(reviewer_Review.ReviewerId, reviewer_Review.GameId, reviewer_Review.Order_of_review);
            //Console.WriteLine(reviewer_Review.ToString());

            //// Pomocná funkcia, ktorá sa nenachádza v analýze
            //reviewerReviewTable.delete(reviewer_Review.ReviewerId, reviewer_Review.GameId, reviewer_Review.Order_of_review);

            //// Funkcia 6.3.i Zoznam užívateľských recenzií
            //List<Reviewer_review> revs = reviewerReviewTable.selectReviews();
            //foreach (Reviewer_review rv in revs)
            //{
            //    Console.WriteLine(rv.ToStringHeader());
            //}

            //// Funkcia 6.3.i Zoznam užívateľských recenzií (varianta pre recenzenta)
            //revs = reviewerReviewTable.selectReviewsForReviewer(1);
            //foreach (Reviewer_review rv in revs)
            //{
            //    Console.WriteLine(rv.ToStringHeader());
            //}

            //// Funkcia 6.3.i Zoznam užívateľských recenzií (varianta pre hru)
            //revs = reviewerReviewTable.selectReviewsForGame(1);
            //foreach (Reviewer_review rv in revs)
            //{
            //    Console.WriteLine(rv.ToStringHeader());
            //}

            //Console.WriteLine("UserReview done!\n");
            ////------------------------------------------------

            //Routines routines = new Routines();

            //// Funkcia 6.4.g Vypočítanie nového priemerného užívateľského skóre pre každú hru 
            //routines.updateUserScore();

            ////Funkcia 6.4.h Vypočítanie nového priemerného recenzentskeho skóre pre každú hru 
            //routines.updateReviewerScore();

            ////Funkcia 6.4.i Povýšenie užívateľa na recenzenta a zmazanie všetkých jeho doterajších užívateľských recenzií
            //routines.promoteUser(8);

            ////Funkcia 6.4.j	Povýšenie užívateľa na recenzenta a povýšenie všetkých jeho doterajších užívateľských recenzií na recenzentské recenzie.
            //routines.promoteUserAndHisReviews(15);

            ////Funkcia 6.4.m. Zobrazenie posledných 10 recenzentských recenzií na určitú hru
            //Tuple<string, int> tuple1 = routines.lastTenReviews(1);
            //Console.WriteLine(tuple1.Item1 + " " + tuple1.Item2);

            ////Funkcia 6.4.l Zobrazenie počtu recenzií a priemerného skóre od užívateľov, ktori recenzovali hru s priemerným hodnotením 7+
            //Tuple<int, int, double> tuple = routines.countAndAvg();
            //Console.WriteLine("User id: " + tuple.Item1 + " Number of reviews: " + tuple.Item2 + " Average score: " + tuple.Item3);

            //Console.WriteLine("Routines done!\n");

            //// Bonusová funkcia (problém N+1)
            //GameTable gameTable1 = new GameTable();
            //List<Game> games1 = gameTable1.selectGamesWithCategories();
            //foreach (Game g in games1)
            //{
            //    Console.WriteLine(g.ToStringHeader());
            //    foreach (Category c in g.Categories)
            //    {
            //        Console.WriteLine(c.ToString());
            //    }
            //}

            //Console.WriteLine("Bonus done!\n");

            //Console.ReadKey();
        }
    }
}
