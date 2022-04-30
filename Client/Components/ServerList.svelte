<script>
  import {badplaceData} from '../js/stores';
  import {onDestroy} from 'svelte';
  import ServerCard from './ServerCard.svelte';

  let badplaceDataValue;
  const unsubscribe = badplaceData.subscribe(value => {
    badplaceDataValue = value;
  });
  onDestroy(unsubscribe);
</script>

<div>
  {#each badplaceDataValue as serverData}
    <ServerCard server={serverData} />
  {/each}
</div>

<style>
  div {
    display: flex;
    flex-direction: row;
    align-items: flex-start;
    justify-content: flex-start;
    flex-wrap: wrap;
  }
</style>
