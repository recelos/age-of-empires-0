using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgeOfEmpires0;

namespace AgeOfEmpires0
{
    public partial class GameForm : Form
    {
        /// <summary>
        /// Zmienna zliczająca ilość wieśniaków
        /// </summary>
        private int _villagerCounter;

        /// <summary>
        /// Zmienna zliczająca ilość wolnych wieśniaków
        /// </summary>
        private int _freeVillagers;
        /// <summary>
        /// Zmienna przechowująca obecną liczbę populacji
        /// </summary>
        private int _currentPopulation;
        /// <summary>
        /// Zmienna przechowująca maksymalną liczbę populacji
        /// </summary>
        private int _maxPopulation;


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
        private uint _infantry;
        /// <summary>
        /// Zmienna przechowująca ilość kawalerii
        /// </summary>
        private uint _cavalry;
        /// <summary>
        /// Zmienna przechowująca ilość katapult
        /// </summary>
        private uint _catapults;

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
            _villagerCounter = 3;
            _freeVillagers = 3;

            _currentPopulation = 3;
            _maxPopulation = 10;

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
            villagerTextBox.Text = $"{_freeVillagers}/{_villagerCounter}";
            UpdateTextBoxes();

            goldCollectorsTextBox.Text = $"{_gold.CollectorsAmount}";
            foodCollectorsTextBox.Text = $"{_food.CollectorsAmount}";
            stoneCollectorsTextBox.Text = $"{_stone.CollectorsAmount}";
            woodCollectorsTextBox.Text = $"{_wood.CollectorsAmount}";
            ironCollectorsTextBox.Text = $"{_iron.CollectorsAmount}";
            populationTextBox.Text = $"{_currentPopulation} / {_maxPopulation}";
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
            UpdateTextBoxes();
        }
        /// <summary>
        /// Jeśli jest przynajmniej jeden wieśniak zbierający złoto, zabiera go i
        /// dodaje do puli wolnych wieśniaków.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubtractGoldCollectorButton_Click(object sender, EventArgs e)
        {
            if (_gold.CollectorsAmount!=0)
            {
                _gold.CollectorsAmount--;
                _freeVillagers++;
                villagerTextBox.Text = $"{_freeVillagers}/{_villagerCounter}";
                goldCollectorsTextBox.Text = $"{_gold.CollectorsAmount}";
            }
        }
        /// <summary>
        /// Dodaje jednego zbierającego złoto jeśli jest dostępny wolny wieśniak.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddGoldCollectorButton_Click(object sender, EventArgs e)
        {
            if (_freeVillagers != 0)
            {
                _gold.CollectorsAmount++;
                _freeVillagers--;
                villagerTextBox.Text = $"{_freeVillagers}/{_villagerCounter}";
                goldCollectorsTextBox.Text = $"{_gold.CollectorsAmount}";

            }
        }
        /// <summary>
        /// Jeśli jest przynajmniej jeden wieśniak zbierający jedzenie, zabiera go i
        /// dodaje do puli wolnych wieśniaków.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubtractFoodCollectorsButton_Click(object sender, EventArgs e)
        {
            if (_food.CollectorsAmount != 0)
            {
                _food.CollectorsAmount--;
                _freeVillagers++;
                villagerTextBox.Text = $"{_freeVillagers}/{_villagerCounter}";
                foodCollectorsTextBox.Text = $"{_food.CollectorsAmount}";
            }
        }
        /// <summary>
        /// Dodaje jednego zbierającego jedzenie jeśli jest dostępny wolny wieśniak.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFoodCollectorsButton_Click(object sender, EventArgs e)
        {
            if (_freeVillagers != 0)
            {
                _food.CollectorsAmount++;
                _freeVillagers--;
                villagerTextBox.Text = $"{_freeVillagers}/{_villagerCounter}";
                foodCollectorsTextBox.Text = $"{_food.CollectorsAmount}";

            }
        }
        /// <summary>
        /// Jeśli jest przynajmniej jeden wieśniak zbierający kamień, zabiera go i
        /// dodaje do puli wolnych wieśniaków.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubtractStoneCollectorsButton_Click(object sender, EventArgs e)
        {
            if (_stone.CollectorsAmount != 0)
            {
                _stone.CollectorsAmount--;
                _freeVillagers++;
                villagerTextBox.Text = $"{_freeVillagers}/{_villagerCounter}";
                stoneCollectorsTextBox.Text = $"{_stone.CollectorsAmount}";
            }
        }
        /// <summary>
        /// Dodaje jednego zbierającego kamień jeśli jest dostępny wolny wieśniak.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStoneCollectorsButton_Click(object sender, EventArgs e)
        {
            if (_freeVillagers != 0)
            {
                _stone.CollectorsAmount++;
                _freeVillagers--;
                villagerTextBox.Text = $"{_freeVillagers}/{_villagerCounter}";
                stoneCollectorsTextBox.Text = $"{_stone.CollectorsAmount}";

            }
        }
        /// <summary>
        /// Jeśli jest przynajmniej jeden wieśniak zbierający drewno, zabiera go i
        /// dodaje do puli wolnych wieśniaków.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubtractWoodCollectorsButton_Click(object sender, EventArgs e)
        {
            {
                if (_wood.CollectorsAmount != 0)
                {
                    _wood.CollectorsAmount--;
                    _freeVillagers++;
                    villagerTextBox.Text = $"{_freeVillagers}/{_villagerCounter}";
                    woodCollectorsTextBox.Text = $"{_wood.CollectorsAmount}";
                }
            }
        }
        /// <summary>
        /// Dodaje jednego zbierającego drewno jeśli jest dostępny wolny wieśniak.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWoodCollectorsButton_Click(object sender, EventArgs e)
        {
            if (_freeVillagers != 0)
            {
                _wood.SubtractCollectors(ref _freeVillagers);
                villagerTextBox.Text = $"{_freeVillagers}/{_villagerCounter}";
                woodCollectorsTextBox.Text = $"{_wood.CollectorsAmount}";

            }
        }
        /// <summary>
        /// Jeśli jest przynajmniej jeden wieśniak zbierający żelazo, zabiera go i
        /// dodaje do puli wolnych wieśniaków.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubtractIronCollectorsButton_Click(object sender, EventArgs e)
        {
            if (_iron.CollectorsAmount != 0) 
            { 
                _iron.CollectorsAmount--; 
                _freeVillagers++; 
                villagerTextBox.Text = $"{_freeVillagers}/{_villagerCounter}"; 
                ironCollectorsTextBox.Text = $"{_iron.CollectorsAmount}";
            }
            
        }
        /// <summary>
        /// Dodaje jednego zbierającego żelazo jeśli jest dostępny wolny wieśniak.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIronCollectorsButton_Click(object sender, EventArgs e)
        {
            if (_freeVillagers != 0)
            {
                _iron.CollectorsAmount++;
                _freeVillagers--;
                villagerTextBox.Text = $"{_freeVillagers}/{_villagerCounter}";
                ironCollectorsTextBox.Text = $"{_iron.CollectorsAmount}";

            }
        }
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
            else if (_currentPopulation < _maxPopulation)
            {
                _food.Amount -= 50;
                _currentPopulation++;
                _villagerCounter++;
                _freeVillagers++;
                villagerTextBox.Text = $"{_freeVillagers}/{_villagerCounter}";
                populationTextBox.Text = $"{_currentPopulation} / {_maxPopulation}";
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
            else if (_maxPopulation < 200)
            {
                _wood.Amount -= 100;
                _maxPopulation += 10;
                populationTextBox.Text = $"{_currentPopulation} / {_maxPopulation}";
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
            else if (_currentPopulation < _maxPopulation)
            {
                _gold.Amount -= 50;
                _iron.Amount -= 100;
                _currentPopulation++;
                _infantry++;
                infantryTextBox.Text = _infantry.ToString();
                populationTextBox.Text = $"{_currentPopulation} / {_maxPopulation}";
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
            else if (_currentPopulation < _maxPopulation - 1)
            {
                _food.Amount -= 50;
                _gold.Amount -= 100;
                _currentPopulation += 2;
                _cavalry++;
                cavalryTextBox.Text = _cavalry.ToString();
                populationTextBox.Text = $"{_currentPopulation} / {_maxPopulation}";
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
            else if (_currentPopulation < _maxPopulation - 2)
            {
                _gold.Amount -= 50;
                _wood.Amount -= 100;
                _stone.Amount -= 50;
                _currentPopulation += 3;
                _catapults++;
                artilleryTextBox.Text = _catapults.ToString();
                populationTextBox.Text = $"{_currentPopulation} / {_maxPopulation}";
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
            _enemyBaseHP -= (int)damage;
          

            // zwalnia w miejsce w populacji po ataku
            var populationToDelete = _infantry + _cavalry * 2 + _catapults * 3;
            _currentPopulation -= populationToDelete;


            enemyBaseProgressBar.Value = _enemyBaseHP;

            _infantry = 0;
            _cavalry = 0;
            _catapults = 0;

            populationTextBox.Text = $"{_currentPopulation} / {_maxPopulation}";
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
    }
}
