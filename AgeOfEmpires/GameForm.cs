using System;
using System.Windows.Forms;

namespace AgeOfEmpires0
{
    public partial class GameForm : Form
    {

        /// <summary>
        /// Obiekt obsługujący populację w oraz osadników
        /// </summary>
        private PopulationHandler _popHandler;


        /// <summary>
        /// Zmienna przechowująca ilość złota
        /// </summary>
        private Resource _gold;

        /// <summary>
        /// Zmienna przechowująca ilość jedzenia
        /// </summary>
        private Resource _food;

        /// <summary>
        /// Zmienna przechowująca ilość kamienia
        /// </summary>
        private Resource _stone;

        /// <summary>
        /// Zmienna przechowująca ilość drewna
        /// </summary>
        private Resource _wood;

        /// <summary>
        /// Zmienna przechowująca ilość żelaza
        /// </summary>
        private Resource _iron;

        /// <summary>
        /// Zmienna przechowująca ilość piechoty
        /// </summary>
        private int _infantry;
        /// <summary>
        /// Zmienna przechowująca ilość kawalerii
        /// </summary>
        private int _cavalry;
        /// <summary>
        /// Zmienna przechowująca ilość katapult
        /// </summary>
        private int _catapults;

        /// <summary>
        /// Zmienna przechowująca punkty życua bazy przeciwnika
        /// </summary>
        private int _enemyBaseHP;
        /// <summary>
        /// Zmienna przechowującą punkty życia bazy gracza
        /// </summary>
        private int _playerBaseHP;

        /// <summary>
        /// Zmienna przechowująca czas do ataku wroga w sekundach
        /// </summary>
        private int _timeToEnemyAttack;

        /// <summary>
        /// Funkcja nadająca wartości zmiennym na początku gry. 
        /// Gracz rozpoczyna rozgrywke z trzema wieśniakami.
        /// </summary>
        private void SetInitialValues()
        {
            _popHandler = new PopulationHandler();


            _infantry = 0;
            _cavalry = 0;
            _catapults = 0;


            _gold = new Resource(50);
            _food = new Resource(100);
            _stone = new Resource(0);
            _wood = new Resource(50);
            _iron = new Resource(0);


            _playerBaseHP = 2000;
            _enemyBaseHP = 2000;
            enemyBaseProgressBar.Value = _enemyBaseHP;
            
            _timeToEnemyAttack = 60;

            enemyAttackTimer.Start();
            updateTimer.Start();
        }


        /// <summary>
        /// Konstruktor okna z ekranem gry. Inicjalizuje początkowe wartości, informacje o zasobach i jednostkach.
        /// </summary>
        public GameForm()
        {
            InitializeComponent();
            SetInitialValues();
            //villagerTextBox.Text = $"{_freeVillagers}/{_villagerCounter}";
            villagerTextBox.Text = $"{_popHandler.FreeVillagers}/{_popHandler.FreeVillagers}";

            UpdateTextBoxes();

            goldCollectorsTextBox.Text = $"{_gold.CollectorsAmount}";
            foodCollectorsTextBox.Text = $"{_food.CollectorsAmount}";
            stoneCollectorsTextBox.Text = $"{_stone.CollectorsAmount}";
            woodCollectorsTextBox.Text = $"{_wood.CollectorsAmount}";
            ironCollectorsTextBox.Text = $"{_iron.CollectorsAmount}";
            populationTextBox.Text = $"{_popHandler.CurrentPopulation} / {_popHandler.MaxPopulation}";
            infantryTextBox.Text = _infantry.ToString();
            cavalryTextBox.Text = _cavalry.ToString();
            artilleryTextBox.Text = _catapults.ToString();
            enemyAttackLabel.Text = $"Time to next attack: {_timeToEnemyAttack}";

            playerBaseHPLabel.Text = $"Player base HP: {_playerBaseHP}";
            enemyBaseHPLabel.Text = $"Enemy base HP: {_enemyBaseHP}";
        }

        /// <summary>
        /// Ustawia tekst z informacją o zasobach.
        /// </summary>
        private void UpdateTextBoxes()
        {
            goldTextBox.Text = $"{_gold.Amount}";
            foodTextBox.Text = $"{_food.Amount}";
            stoneTextBox.Text = $"{_stone.Amount}";
            woodTextBox.Text = $"{_wood.Amount}";
            ironTextBox.Text = $"{_iron.Amount}";
        }
        /// <summary>
        /// Dodaje surowce w zależności od ilości zbierających w interwale 500 ms.
        /// Aktualizuje informacje o posiadanych surowcach.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResourceTimer_Tick(object sender, EventArgs e)
        {
            _gold.Collect();
            _food.Collect();
            _stone.Collect();
            _wood.Collect();
            _iron.Collect();
        }

        #region AddButtonClicks
        /// <summary>
        /// Dodaje jednego zbierającego złoto jeśli jest dostępny wolny wieśniak.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddGoldCollectorButton_Click(object sender, EventArgs e) =>
            IncreaseCollectorsButtonClick(_gold, goldCollectorsTextBox);

        /// <summary>
        /// Dodaje jednego zbierającego jedzenie jeśli jest dostępny wolny wieśniak.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFoodCollectorsButton_Click(object sender, EventArgs e)
            => IncreaseCollectorsButtonClick(_food, foodCollectorsTextBox);

        /// <summary>
        /// Dodaje jednego zbierającego drewno jeśli jest dostępny wolny wieśniak.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWoodCollectorsButton_Click(object sender, EventArgs e) =>
            IncreaseCollectorsButtonClick(_wood, woodCollectorsTextBox);

        /// <summary>
        /// Dodaje jednego zbierającego kamień jeśli jest dostępny wolny wieśniak.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStoneCollectorsButton_Click(object sender, EventArgs e) =>
            IncreaseCollectorsButtonClick(_stone, stoneCollectorsTextBox);

        /// <summary>
        /// Dodaje jednego zbierającego żelazo jeśli jest dostępny wolny wieśniak.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIronCollectorsButton_Click(object sender, EventArgs e) =>
            IncreaseCollectorsButtonClick(_iron, ironCollectorsTextBox);
        #endregion
        #region SubtractButtonClicks
        /// <summary>
        /// Jeśli jest przynajmniej jeden wieśniak zbierający złoto, zabiera go i
        /// dodaje do puli wolnych wieśniaków.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubtractGoldCollectorButton_Click(object sender, EventArgs e) =>
            DecreaseCollectorsButtonClick(_gold, goldCollectorsTextBox);

        /// <summary>
        /// Jeśli jest przynajmniej jeden wieśniak zbierający jedzenie, zabiera go i
        /// dodaje do puli wolnych wieśniaków.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubtractFoodCollectorsButton_Click(object sender, EventArgs e) =>
            DecreaseCollectorsButtonClick(_food, foodCollectorsTextBox);

        /// <summary>
        /// Jeśli jest przynajmniej jeden wieśniak zbierający kamień, zabiera go i
        /// dodaje do puli wolnych wieśniaków.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubtractStoneCollectorsButton_Click(object sender, EventArgs e) =>
            DecreaseCollectorsButtonClick(_stone, stoneCollectorsTextBox);

        /// <summary>
        /// Jeśli jest przynajmniej jeden wieśniak zbierający drewno, zabiera go i
        /// dodaje do puli wolnych wieśniaków.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubtractWoodCollectorsButton_Click(object sender, EventArgs e) =>
            DecreaseCollectorsButtonClick(_wood, woodCollectorsTextBox);

        /// <summary>
        /// Jeśli jest przynajmniej jeden wieśniak zbierający żelazo, zabiera go i
        /// dodaje do puli wolnych wieśniaków.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubtractIronCollectorsButton_Click(object sender, EventArgs e) =>
            DecreaseCollectorsButtonClick(_iron, ironCollectorsTextBox);
        #endregion

        /// <summary>
        /// Tworzy nowego wieśniaka i dodaje wolnego wieśniaka jeśli posiadana jest odpowiednia ilość
        /// surowca.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddVillagerButton_Click(object sender, EventArgs e)
        {
            if (_food.Amount < 50)
            {
                DisplayNotEnoughResourcesLabel();
            } 
            else if (_popHandler.CurrentPopulation < _popHandler.MaxPopulation)
            {
                _food.Amount -= 50;
                _popHandler.CurrentPopulation++;
                _popHandler.AllVillagers++;
                _popHandler.FreeVillagers++;
                villagerTextBox.Text = $"{_popHandler.FreeVillagers}/{_popHandler.AllVillagers}";
                populationTextBox.Text = $"{_popHandler.CurrentPopulation} / {_popHandler.MaxPopulation}";
            }
        }
        /// <summary>
        /// Buduje dom i zwiększa limit populacji jeśli nie zostało osiągnięte maksimum i posiadana jest
        /// odpowiednia ilość surowców.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HouseButton_Click(object sender, EventArgs e)
        {
            if (_wood.Amount < 100)
            {
                DisplayNotEnoughResourcesLabel();
            }
            else if (_popHandler.MaxPopulation < 200)
            {
                _wood.Amount -= 100;
                _popHandler.MaxPopulation += 10;
                populationTextBox.Text = $"{_popHandler.CurrentPopulation} / {_popHandler.MaxPopulation}";
            }
        }
        /// <summary>
        /// Tworzy piechotę jeśli gracz posiada wymaganą ilość surowców i miejsca. 
        /// Zwiększa ilość obecnej populacji o 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateInfantryButton_Click(object sender, EventArgs e)
        {
            if (_gold.Amount < 50 || _iron.Amount < 100)
            {
                DisplayNotEnoughResourcesLabel();
            }
            else if (_popHandler.CurrentPopulation < _popHandler.MaxPopulation)
            {
                _gold.Amount -= 50;
                _iron.Amount -= 100;
                _popHandler.CurrentPopulation++;
                _infantry++;
                infantryTextBox.Text = _infantry.ToString();
                populationTextBox.Text = $"{_popHandler.CurrentPopulation} / {_popHandler.MaxPopulation}";
            }
        }
        /// <summary>
        /// Tworzy kawalerie jeśli gracz posiada wymaganą ilość surowców i miejsca.
        /// Zwiększa ilość obecnej populacji o 2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateCavalryButton_Click(object sender, EventArgs e)
        {
            if (_food.Amount < 50 || _gold.Amount < 100)
            {
                DisplayNotEnoughResourcesLabel();
            }
            else if (_popHandler.CurrentPopulation < _popHandler.MaxPopulation - 1)
            {
                _food.Amount -= 50;
                _gold.Amount -= 100;
                _popHandler.CurrentPopulation += 2;
                _cavalry++;
                cavalryTextBox.Text = _cavalry.ToString();
                populationTextBox.Text = $"{_popHandler.CurrentPopulation} / {_popHandler.MaxPopulation}";
            }
        }
        /// <summary>
        /// Tworzy katapulty jeśli gracz posiada wymaganą ilość surowców i miejsca.
        /// Zwiększa ilość obecnej populacji o 3.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateCatapultButton_Click(object sender, EventArgs e)
        {
            if (_gold.Amount < 50 || _wood.Amount < 100 || _stone.Amount < 50)
            {
                DisplayNotEnoughResourcesLabel();
            }
            else if (_popHandler.CurrentPopulation < _popHandler.MaxPopulation - 2)
            {
                _gold.Amount -= 50;
                _wood.Amount -= 100;
                _stone.Amount -= 50;
                _popHandler.CurrentPopulation += 3;
                _catapults++;
                artilleryTextBox.Text = _catapults.ToString();
                populationTextBox.Text = $"{_popHandler.CurrentPopulation} / {_popHandler.MaxPopulation}";
            }
        }
        /// <summary>
        /// Tworzy koszary i umożliwia budowanie jednostek wojskowych.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateBarracksButton_Click(object sender, EventArgs e)
        {
            if (_wood.Amount < 100 || _stone.Amount < 100)
            {
                DisplayNotEnoughResourcesLabel();
            }
            else
            {
                _wood.Amount -= 100;
                _stone.Amount -= 100;
                
                // umożliwia budowanie wojsk po utworzeniu koszar
                createInfantryButton.Visible = true;
                createInfantryButton.Enabled = true;
                infantryTextBox.Visible = true;
                infantryLabel.Visible = true;

                createCavalryButton.Visible = true;
                createCavalryButton.Enabled = true;
                cavalryTextBox.Visible = true;
                cavalryLabel.Visible = true;

                createCatapultButton.Visible = true;
                createCatapultButton.Enabled = true;
                artilleryTextBox.Visible = true;
                catapultLabel.Visible = true;

                createBarracksButton.Enabled = false;
            }
        }

        /// <summary>
        /// Wyświetla ostrzeżenie o braku surowców na czas 1 sekundy.
        /// </summary>
        private void DisplayNotEnoughResourcesLabel()
        {

            notEnoughResourcesLabel.Visible = true;
            Timer timer = new();
            timer.Interval = 1000;

            timer.Tick += (object sender, EventArgs e) =>
            {
                notEnoughResourcesLabel.Visible = false;
                timer.Stop();
            };
            timer.Start();
        }


        /// <summary>
        /// Atakuje bazę przeciwnika i w zależności od ilości żołnierzy zadaje
        /// określone obrażenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttackEnemyBase_Click(object sender, EventArgs e)
        {
            var damage = _infantry * 10 + _cavalry * 20 + _catapults * 50;
            if (_enemyBaseHP <= damage)
            {
                enemyAttackTimer.Stop();
                Hide();
                EndingScreenForm endingScreen = new EndingScreenForm("You won!");
                endingScreen.ShowDialog();
                Close();
                return;
            }
            _enemyBaseHP -= damage;
          

            // zwalnia w miejsce w populacji po ataku
            var populationToDelete = _infantry + _cavalry * 2 + _catapults * 3;
            _popHandler.CurrentPopulation -= populationToDelete;


            enemyBaseProgressBar.Value = _enemyBaseHP;

            _infantry = 0;
            _cavalry = 0;
            _catapults = 0;

            populationTextBox.Text = $"{_popHandler.CurrentPopulation} / {_popHandler.MaxPopulation}";
            infantryTextBox.Text = _infantry.ToString();
            cavalryTextBox.Text = _cavalry.ToString();
            artilleryTextBox.Text = _cavalry.ToString();
            enemyBaseHPLabel.Text = $"Enemy base HP: {_enemyBaseHP}";
            MessageBox.Show($"You dealt {damage} damage");
        }

        /// <summary>
        /// Zlicza czas do następnego ataku wroga.
        /// Kiedy czas dojdzie do zera zadaje obrażenia bazie gracza
        /// i resetuje timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnemyAttackTimer_Tick(object sender, EventArgs e)
        {
            if (_timeToEnemyAttack == 0)
            {
                var damage = new Random().Next(50,200);
                if (damage >= _playerBaseHP)
                {
                    enemyAttackTimer.Stop();
                    Hide();
                    EndingScreenForm endingScreen = new EndingScreenForm("You lost!");
                    endingScreen.ShowDialog();
                    Close();
                    return;
                }
                _playerBaseHP -= damage;
                _timeToEnemyAttack = 60;
                playerHPProgressBar.Value = _playerBaseHP;
                enemyAttackLabel.Text = $"Time to next attack: {_timeToEnemyAttack}";
                playerBaseHPLabel.Text = $"Player base HP: {_playerBaseHP}";
                MessageBox.Show($"You have been attacked! Your base lost {damage}HP", "Enemy Attack", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _timeToEnemyAttack--;
                enemyAttackLabel.Text = $"Time to next attack: {_timeToEnemyAttack}s";
            }
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateTextBoxes();
        }

        private void IncreaseCollectorsButtonClick(Resource res, TextBox textBox)
        {
            if (_popHandler.FreeVillagers != 0)
            {
                res.CollectorsAmount++;
                _popHandler.FreeVillagers--;
                villagerTextBox.Text = $"{_popHandler.FreeVillagers}/{_popHandler.AllVillagers}";
                textBox.Text = $"{res.CollectorsAmount}";
            }
        }

        private void DecreaseCollectorsButtonClick(Resource res, TextBox textBox)
        {
            if (res.CollectorsAmount != 0)
            {
                res.CollectorsAmount--;
                _popHandler.FreeVillagers++;
                villagerTextBox.Text = $"{_popHandler.FreeVillagers}/{_popHandler.AllVillagers}";
                textBox.Text = $"{res.CollectorsAmount}";
            }
        }
    }
}
