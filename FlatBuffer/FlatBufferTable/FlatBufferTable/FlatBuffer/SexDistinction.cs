// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SexDistinction : Table {
  public static FB_SexDistinction GetRootAsFB_SexDistinction(ByteBuffer _bb) { return GetRootAsFB_SexDistinction(_bb, new FB_SexDistinction()); }
  public static FB_SexDistinction GetRootAsFB_SexDistinction(ByteBuffer _bb, FB_SexDistinction obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SexDistinction __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetMaleStartEffectList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MaleStartEffectListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetFemaleStartEffectList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FemaleStartEffectListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int MaleSoundID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FemaleSoundID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SexDistinction> CreateFB_SexDistinction(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset MaleStartEffectList = default(VectorOffset),
      VectorOffset FemaleStartEffectList = default(VectorOffset),
      int MaleSoundID = -1,
      int FemaleSoundID = -1) {
    builder.StartObject(5);
    FB_SexDistinction.AddFemaleSoundID(builder, FemaleSoundID);
    FB_SexDistinction.AddMaleSoundID(builder, MaleSoundID);
    FB_SexDistinction.AddFemaleStartEffectList(builder, FemaleStartEffectList);
    FB_SexDistinction.AddMaleStartEffectList(builder, MaleStartEffectList);
    FB_SexDistinction.AddID(builder, ID);
    return FB_SexDistinction.EndFB_SexDistinction(builder);
  }

  public static void StartFB_SexDistinction(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMaleStartEffectList(FlatBufferBuilder builder, VectorOffset MaleStartEffectListOffset) { builder.AddOffset(1, MaleStartEffectListOffset.Value, 0); }
  public static VectorOffset CreateMaleStartEffectListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMaleStartEffectListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFemaleStartEffectList(FlatBufferBuilder builder, VectorOffset FemaleStartEffectListOffset) { builder.AddOffset(2, FemaleStartEffectListOffset.Value, 0); }
  public static VectorOffset CreateFemaleStartEffectListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFemaleStartEffectListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMaleSoundID(FlatBufferBuilder builder, int MaleSoundID) { builder.AddInt(3, MaleSoundID, -1); }
  public static void AddFemaleSoundID(FlatBufferBuilder builder, int FemaleSoundID) { builder.AddInt(4, FemaleSoundID, -1); }
  public static Offset<FB_SexDistinction> EndFB_SexDistinction(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SexDistinction>(o);
  }
};

public sealed class FB_SexDistinctionContainer : Table {
  public static FB_SexDistinctionContainer GetRootAsFB_SexDistinctionContainer(ByteBuffer _bb) { return GetRootAsFB_SexDistinctionContainer(_bb, new FB_SexDistinctionContainer()); }
  public static FB_SexDistinctionContainer GetRootAsFB_SexDistinctionContainer(ByteBuffer _bb, FB_SexDistinctionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SexDistinctionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SexDistinctionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SexDistinction GetItems(int j) { return GetItems(new FB_SexDistinction(), j); }
  public FB_SexDistinction GetItems(FB_SexDistinction obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SexDistinctionContainer> CreateFB_SexDistinctionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SexDistinctionContainer.AddItems(builder, items);
    return FB_SexDistinctionContainer.EndFB_SexDistinctionContainer(builder);
  }

  public static void StartFB_SexDistinctionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SexDistinction>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SexDistinctionContainer> EndFB_SexDistinctionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SexDistinctionContainer>(o);
  }
  public static void FinishFB_SexDistinctionContainerBuffer(FlatBufferBuilder builder, Offset<FB_SexDistinctionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
