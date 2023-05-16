const PLAYER_STATS_BASE_URL = 'https://localhost:8080/PlayerStats';

export async function GetTopScorers() {
  const response = await fetch(`${PLAYER_STATS_BASE_URL}/GetTopScorers`, {
    method: 'GET',
  });

  return response.json();
}

export async function GetPlayerById(id: number) {
  const response = await fetch(`${PLAYER_STATS_BASE_URL}/GetPlayerStatsById`, {
    method: 'GET',
  });

  return response.json();
}
