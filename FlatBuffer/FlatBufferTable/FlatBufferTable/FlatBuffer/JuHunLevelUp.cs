// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JuHunLevelUp : Table {
  public static FB_JuHunLevelUp GetRootAsFB_JuHunLevelUp(ByteBuffer _bb) { return GetRootAsFB_JuHunLevelUp(_bb, new FB_JuHunLevelUp()); }
  public static FB_JuHunLevelUp GetRootAsFB_JuHunLevelUp(ByteBuffer _bb, FB_JuHunLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JuHunLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetQualityList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int QualityListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JuHunLevelUp> CreateFB_JuHunLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset QualityList = default(VectorOffset)) {
    builder.StartObject(2);
    FB_JuHunLevelUp.AddQualityList(builder, QualityList);
    FB_JuHunLevelUp.AddID(builder, ID);
    return FB_JuHunLevelUp.EndFB_JuHunLevelUp(builder);
  }

  public static void StartFB_JuHunLevelUp(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddQualityList(FlatBufferBuilder builder, VectorOffset QualityListOffset) { builder.AddOffset(1, QualityListOffset.Value, 0); }
  public static VectorOffset CreateQualityListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartQualityListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JuHunLevelUp> EndFB_JuHunLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JuHunLevelUp>(o);
  }
};

public sealed class FB_JuHunLevelUpContainer : Table {
  public static FB_JuHunLevelUpContainer GetRootAsFB_JuHunLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_JuHunLevelUpContainer(_bb, new FB_JuHunLevelUpContainer()); }
  public static FB_JuHunLevelUpContainer GetRootAsFB_JuHunLevelUpContainer(ByteBuffer _bb, FB_JuHunLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JuHunLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JuHunLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JuHunLevelUp GetItems(int j) { return GetItems(new FB_JuHunLevelUp(), j); }
  public FB_JuHunLevelUp GetItems(FB_JuHunLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JuHunLevelUpContainer> CreateFB_JuHunLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JuHunLevelUpContainer.AddItems(builder, items);
    return FB_JuHunLevelUpContainer.EndFB_JuHunLevelUpContainer(builder);
  }

  public static void StartFB_JuHunLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JuHunLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JuHunLevelUpContainer> EndFB_JuHunLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JuHunLevelUpContainer>(o);
  }
  public static void FinishFB_JuHunLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_JuHunLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
