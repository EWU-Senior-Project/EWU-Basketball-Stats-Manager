export async function GetTopScorers(teamId: number) {
  const response = await fetch(
    `https://localhost:8080/PlayerStats/GetTopScorers?teamId=${teamId}`,
    {
      method: 'GET',
    }
  );

  return response.json();
}
