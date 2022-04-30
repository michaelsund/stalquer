<script>
  import TeamsAndPlayers from './TeamsAndPlayers.svelte';
  export let server;

  const gameMode = deathmatch => {
    let mode = '';
    switch (deathmatch) {
      case 3:
        mode = '1v1';
        break;
      case 4:
        mode = '4v4';
        break;
      default:
        break;
    }
    return mode;
  };
</script>

<!-- <div
  style="background-image: url(https://quakedemos.blob.core.windows.net/maps/thumbnails/{server.map}.jpg);"
> -->
<div>
  <h4>{server.title}</h4>
  <p>{server.description}</p>
  <p>Ip: {server.address}</p>
  <p>Map: {server.map}</p>
  <p>deathmath: {server.settings.deathmatch} teamplay: {server.settings.teamplay}</p>
  <p>Mode: {gameMode(server.settings.deathmatch, server.settings.teamplay)}</p>
  <p>{server.players.length}/{server.maxClients + server.maxSpectators}</p>
  <TeamsAndPlayers playersOnServer={server.players} />
  <!-- <ul>
    {#each server.players as player}
      <li>{player.name} <b>{player.frags >= 0 ? `frags: ${player.frags}` : ''}</b></li>
    {/each}
  </ul> -->
</div>

<style>
  div {
    background-repeat: no-repeat;
    background-position: center center;
    background-size: cover;
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    flex-wrap: wrap;
    margin: 0 1em 1em 0;
    background-color: white;
    border-radius: 5px;
    padding: 1em;
    box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
  }
</style>
