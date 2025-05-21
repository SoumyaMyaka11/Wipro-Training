for (int i = row - 1, j = col; i >= 0 && j >= 0; i--,j--)
{
    if (board[i, j] == 'Q')
        return false;
}