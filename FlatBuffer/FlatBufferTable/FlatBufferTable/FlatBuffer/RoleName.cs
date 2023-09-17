// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RoleName : Table {
  public static FB_RoleName GetRootAsFB_RoleName(ByteBuffer _bb) { return GetRootAsFB_RoleName(_bb, new FB_RoleName()); }
  public static FB_RoleName GetRootAsFB_RoleName(ByteBuffer _bb, FB_RoleName obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RoleName __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Surnname { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string MaleName { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string FemaleName { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string PreSymbol { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string MidSymbol { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public string PostSymbol { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SurnnameNum { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)73; } }
  public int MaleNameNum { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)666; } }
  public int FemaleNameNum { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)666; } }
  public int PreSymbolNum { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)182; } }
  public int MidSymbolNum { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)26; } }
  public int PostSymbolNum { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)25; } }

  public static Offset<FB_RoleName> CreateFB_RoleName(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Surnname = default(StringOffset),
      StringOffset MaleName = default(StringOffset),
      StringOffset FemaleName = default(StringOffset),
      StringOffset PreSymbol = default(StringOffset),
      StringOffset MidSymbol = default(StringOffset),
      StringOffset PostSymbol = default(StringOffset),
      int SurnnameNum = 73,
      int MaleNameNum = 666,
      int FemaleNameNum = 666,
      int PreSymbolNum = 182,
      int MidSymbolNum = 26,
      int PostSymbolNum = 25) {
    builder.StartObject(13);
    FB_RoleName.AddPostSymbolNum(builder, PostSymbolNum);
    FB_RoleName.AddMidSymbolNum(builder, MidSymbolNum);
    FB_RoleName.AddPreSymbolNum(builder, PreSymbolNum);
    FB_RoleName.AddFemaleNameNum(builder, FemaleNameNum);
    FB_RoleName.AddMaleNameNum(builder, MaleNameNum);
    FB_RoleName.AddSurnnameNum(builder, SurnnameNum);
    FB_RoleName.AddPostSymbol(builder, PostSymbol);
    FB_RoleName.AddMidSymbol(builder, MidSymbol);
    FB_RoleName.AddPreSymbol(builder, PreSymbol);
    FB_RoleName.AddFemaleName(builder, FemaleName);
    FB_RoleName.AddMaleName(builder, MaleName);
    FB_RoleName.AddSurnname(builder, Surnname);
    FB_RoleName.AddId(builder, Id);
    return FB_RoleName.EndFB_RoleName(builder);
  }

  public static void StartFB_RoleName(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddSurnname(FlatBufferBuilder builder, StringOffset SurnnameOffset) { builder.AddOffset(1, SurnnameOffset.Value, 0); }
  public static void AddMaleName(FlatBufferBuilder builder, StringOffset MaleNameOffset) { builder.AddOffset(2, MaleNameOffset.Value, 0); }
  public static void AddFemaleName(FlatBufferBuilder builder, StringOffset FemaleNameOffset) { builder.AddOffset(3, FemaleNameOffset.Value, 0); }
  public static void AddPreSymbol(FlatBufferBuilder builder, StringOffset PreSymbolOffset) { builder.AddOffset(4, PreSymbolOffset.Value, 0); }
  public static void AddMidSymbol(FlatBufferBuilder builder, StringOffset MidSymbolOffset) { builder.AddOffset(5, MidSymbolOffset.Value, 0); }
  public static void AddPostSymbol(FlatBufferBuilder builder, StringOffset PostSymbolOffset) { builder.AddOffset(6, PostSymbolOffset.Value, 0); }
  public static void AddSurnnameNum(FlatBufferBuilder builder, int SurnnameNum) { builder.AddInt(7, SurnnameNum, 73); }
  public static void AddMaleNameNum(FlatBufferBuilder builder, int MaleNameNum) { builder.AddInt(8, MaleNameNum, 666); }
  public static void AddFemaleNameNum(FlatBufferBuilder builder, int FemaleNameNum) { builder.AddInt(9, FemaleNameNum, 666); }
  public static void AddPreSymbolNum(FlatBufferBuilder builder, int PreSymbolNum) { builder.AddInt(10, PreSymbolNum, 182); }
  public static void AddMidSymbolNum(FlatBufferBuilder builder, int MidSymbolNum) { builder.AddInt(11, MidSymbolNum, 26); }
  public static void AddPostSymbolNum(FlatBufferBuilder builder, int PostSymbolNum) { builder.AddInt(12, PostSymbolNum, 25); }
  public static Offset<FB_RoleName> EndFB_RoleName(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RoleName>(o);
  }
};

public sealed class FB_RoleNameContainer : Table {
  public static FB_RoleNameContainer GetRootAsFB_RoleNameContainer(ByteBuffer _bb) { return GetRootAsFB_RoleNameContainer(_bb, new FB_RoleNameContainer()); }
  public static FB_RoleNameContainer GetRootAsFB_RoleNameContainer(ByteBuffer _bb, FB_RoleNameContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RoleNameContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RoleNameContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RoleName GetItems(int j) { return GetItems(new FB_RoleName(), j); }
  public FB_RoleName GetItems(FB_RoleName obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RoleNameContainer> CreateFB_RoleNameContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RoleNameContainer.AddItems(builder, items);
    return FB_RoleNameContainer.EndFB_RoleNameContainer(builder);
  }

  public static void StartFB_RoleNameContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RoleName>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RoleNameContainer> EndFB_RoleNameContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RoleNameContainer>(o);
  }
  public static void FinishFB_RoleNameContainerBuffer(FlatBufferBuilder builder, Offset<FB_RoleNameContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
