<script>
  export let playersOnServer = [];

  // const sortTeamsAndPlayers = players => {
  //   let teamsList = [];
  //   players.forEach(player => {
  //     if (teamsList.filter(e => e.team === player.team).length > 0) {
  //       // Add to existing object
  //       const i = teamsList.map(object => object.id).indexOf(player.team);
  //       teamsList[i].players.push(player);
  //     } else {
  //       // Create new team object in teamsList array
  //       teamsList.push({
  //         name: player.team,
  //         players: [player]
  //       });
  //     }
  //   });
  //   console.log(teamsList);
  //   return teamsList;
  // };

  // $: teams = sortTeamsAndPlayers(playersOnServer);
</script>

<div>
  {#each playersOnServer as player}
    {#if !player.spec}
      <p>Player: {player.name} Frags: {player.frags} Time: {player.time}</p>
    {/if}
  {/each}
  <br>
  <p>Spectators</p>
  {#each playersOnServer as player}
    {#if player.spec}
      <p>{player.name} Time: {player.time}</p>
    {/if}
  {/each}
</div>

<style>
  div {
    padding: .5em;
    background: rgba(255, 255, 255, 0.5);
  }
  p {
    color: black;
    margin: 0;
  }
</style>
