// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WarPetRandomStar : Table {
  public static FB_WarPetRandomStar GetRootAsFB_WarPetRandomStar(ByteBuffer _bb) { return GetRootAsFB_WarPetRandomStar(_bb, new FB_WarPetRandomStar()); }
  public static FB_WarPetRandomStar GetRootAsFB_WarPetRandomStar(ByteBuffer _bb, FB_WarPetRandomStar obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WarPetRandomStar __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetStarList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int StarListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetWeightList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WeightListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttributeMultiplierList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttributeMultiplierListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetStarLevelList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int StarLevelListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetRandomStar> CreateFB_WarPetRandomStar(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset StarList = default(VectorOffset),
      VectorOffset WeightList = default(VectorOffset),
      VectorOffset AttributeMultiplierList = default(VectorOffset),
      VectorOffset StarLevelList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_WarPetRandomStar.AddStarLevelList(builder, StarLevelList);
    FB_WarPetRandomStar.AddAttributeMultiplierList(builder, AttributeMultiplierList);
    FB_WarPetRandomStar.AddWeightList(builder, WeightList);
    FB_WarPetRandomStar.AddStarList(builder, StarList);
    FB_WarPetRandomStar.AddID(builder, ID);
    return FB_WarPetRandomStar.EndFB_WarPetRandomStar(builder);
  }

  public static void StartFB_WarPetRandomStar(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddStarList(FlatBufferBuilder builder, VectorOffset StarListOffset) { builder.AddOffset(1, StarListOffset.Value, 0); }
  public static VectorOffset CreateStarListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartStarListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddWeightList(FlatBufferBuilder builder, VectorOffset WeightListOffset) { builder.AddOffset(2, WeightListOffset.Value, 0); }
  public static VectorOffset CreateWeightListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWeightListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttributeMultiplierList(FlatBufferBuilder builder, VectorOffset AttributeMultiplierListOffset) { builder.AddOffset(3, AttributeMultiplierListOffset.Value, 0); }
  public static VectorOffset CreateAttributeMultiplierListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttributeMultiplierListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStarLevelList(FlatBufferBuilder builder, VectorOffset StarLevelListOffset) { builder.AddOffset(4, StarLevelListOffset.Value, 0); }
  public static VectorOffset CreateStarLevelListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartStarLevelListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetRandomStar> EndFB_WarPetRandomStar(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetRandomStar>(o);
  }
};

public sealed class FB_WarPetRandomStarContainer : Table {
  public static FB_WarPetRandomStarContainer GetRootAsFB_WarPetRandomStarContainer(ByteBuffer _bb) { return GetRootAsFB_WarPetRandomStarContainer(_bb, new FB_WarPetRandomStarContainer()); }
  public static FB_WarPetRandomStarContainer GetRootAsFB_WarPetRandomStarContainer(ByteBuffer _bb, FB_WarPetRandomStarContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WarPetRandomStarContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WarPetRandomStarContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WarPetRandomStar GetItems(int j) { return GetItems(new FB_WarPetRandomStar(), j); }
  public FB_WarPetRandomStar GetItems(FB_WarPetRandomStar obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetRandomStarContainer> CreateFB_WarPetRandomStarContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WarPetRandomStarContainer.AddItems(builder, items);
    return FB_WarPetRandomStarContainer.EndFB_WarPetRandomStarContainer(builder);
  }

  public static void StartFB_WarPetRandomStarContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WarPetRandomStar>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetRandomStarContainer> EndFB_WarPetRandomStarContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetRandomStarContainer>(o);
  }
  public static void FinishFB_WarPetRandomStarContainerBuffer(FlatBufferBuilder builder, Offset<FB_WarPetRandomStarContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
