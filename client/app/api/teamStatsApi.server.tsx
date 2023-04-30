export async function GetTopScorers() {
  const response = await fetch(
    'https://localhost:8080/PlayerStats/GetTopScorers',
    {
      method: 'GET',
    }
  );

  return response.json();
}
