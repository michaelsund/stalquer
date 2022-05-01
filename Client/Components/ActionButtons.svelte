<script>
  export let server;

  const openLink = (address, sub) => {
    open(`qw://${address}/${sub}`, '_self');
  };
</script>

<div>
  <button on:click={openLink(server.address, 'observe')}> Spec </button>
  <button on:click={openLink(server.address, '')}> Join </button>
</div>

<style>
  div {
    display: flex;
    justify-content: center;
    align-items: center;
  }
  button {
    min-width: 50%;
  }
  a {
    color: #333;
  }

  a:hover {
    text-decoration: none;
  }

  a:visited {
    color: #333;
  }
</style>
