<script>
  import SignalrHub from './Components/SignalrHub.svelte';
  import ServerList from './Components/ServerList.svelte';
  import FetchBadplaceData from './Components/FetchBadplaceData.svelte';
</script>

<main>
  <h1>Stalquer</h1>
  <ServerList />
  <FetchBadplaceData />
  <SignalrHub />
</main>

<style>
  main {
    margin: 0 auto;
    position: relative;
    min-height: 100vh;
    padding: 1em;
  }
  h1 {
    color: #ff3e00;
    text-transform: uppercase;
    font-size: 4em;
    font-weight: 100;
    width: 100%;
    text-align: center;
  }
  /* @media (min-width: 640px) {
    main {
      max-width: none;
    }
  } */
</style>
