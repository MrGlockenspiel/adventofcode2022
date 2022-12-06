string games = File.ReadAllText("day2.txt").Replace("\n", "").Replace(" ", "");

int score = 0;

char rock = 'A';
char paper = 'B';
char scissors = 'C';

for (int i = 0; i < games.Length; i += 2) {
    char opponents_move = games[i];
    char your_move = games[i + 1];

    if (your_move == 'X' && opponents_move == rock) {
        score += 3;
    } else if (your_move == 'Y' && opponents_move == rock) {
        score += 4;
    } else if (your_move == 'Z' && opponents_move == rock) {
        score += 8;
    } else if (your_move == 'X' && opponents_move == paper) {
        score += 1;
    } else if (your_move == 'Y' && opponents_move == paper) {
        score += 5;
    } else if (your_move == 'Z' && opponents_move == paper) {
        score += 9;
    } else if (your_move == 'X' && opponents_move == scissors) {
        score += 2;
    } else if (your_move == 'Y' && opponents_move == scissors) {
        score += 6;
    } else if (your_move == 'Z' && opponents_move == scissors) {
        score += 7;
    }
}

Console.WriteLine($"Your score would be {score}");